using System.Text;
using UsefulRecords;

namespace WordleModels;
public class WordSifter
{
    public List<string> CommonWords { get; set; } = new List<string>();
    public List<string> CandidateWords { get; set; } = new List<string>();
    public List<LetterScore> LetterScores { get; set; } = new List<LetterScore>();

    public void LoadWords(List<string> words)
    {
        CommonWords.Clear();
        CommonWords.AddRange(words);
    }

    public void ApplyGameMove(GameMove gameMove)
    {
        //firt pass is either ruled out or placed letters.
        //  if there are any placed letters, and if there are more than 5 ruled out, do placed letters first
        var possible = CommonWords;
        var hasPlacedLetters = gameMove.Correct.Any(c => c != ' ');
        if (hasPlacedLetters && gameMove.RuledOut.Count > 5)
        {
            possible = GetWordsWithCorrectLetters(gameMove.Correct, possible);
            possible = GetNotRuledOutWords(gameMove.RuledOut, possible);
        }
        else
        {
            possible = GetNotRuledOutWords(gameMove.RuledOut, possible);
            possible = GetWordsWithCorrectLetters(gameMove.Correct, possible);
        }

        possible = FilterByMisplacedLetters(gameMove.Incorrect, possible);

        CandidateWords = possible;

        ScoreLetters(gameMove, possible);
    }

    public List<string> GetWordsWithCorrectLetters(List<char> correct, List<string> words)
    {
        var placedLetters = new List<LetterPosition>();
        for(var i = 0; i < 5; i++)
        {
            if (correct[i] != ' ')
            {
                placedLetters.Add(new LetterPosition(correct[i], i));
            }
        }

        if (placedLetters.Any())
        {
            var possible = new List<string>();
            foreach (var word in words)
            {
                var impossible = false;
                foreach (var pl in placedLetters)
                {
                    if (word[pl.position] != pl.letter)
                    {
                        impossible = true;
                        break;
                    }
                }
                if (!impossible)
                    possible.Add(word);
            }
            return possible;
        }
        else
        {
            return words;
        }
    }

    public List<string> FilterByMisplacedLetters(List<List<char>> incorrect, List<string> words)
    {
        var misplacedLetters = new List<LetterPosition>();
        for (var i = 0; i < 5; i++)
        {
            var positionList = incorrect[i];
            foreach (var c in positionList)
            {
                misplacedLetters.Add(new LetterPosition(c, i));
            }
        }

        if (misplacedLetters.Any())
        {
            var possible = new List<string>();
            foreach (var word in words)
            {
                var impossible = false;
                foreach (var ml in misplacedLetters)
                {
                    if (word[ml.position] == ml.letter)
                    {
                        impossible = true;
                        break;
                    }
                }
                if(!impossible)
                    possible.Add(word);
            }
            return possible;
        }
        else
        {
            return words;
        }
    }

    public List<string> GetNotRuledOutWords(List<char> ruledOut, List<string> words)
    {
        if (ruledOut.Any())
        {
            var possible = new List<string>();
            foreach (var word in words)
            {
                var impossible = false;
                foreach(var c in ruledOut)
                {
                    if(word.Contains(c))
                    {
                        impossible = true;
                        break;
                    }
                }
                if(!impossible)
                    possible.Add(word);
            }
            return possible;
        }
        else
        {
            return words;
        }
    }

    public void ScoreLetters(GameMove gameMove, List<string> words)
    {
        //get all ruledOut, correct and incorrect letters
        var ignore = new HashSet<char>();
        var scoreList = new List<LetterScore>();

        if(gameMove != null)
        {
            foreach(var c in gameMove.RuledOut)
            {
                ignore.Add(c);
            }
            foreach(var c in gameMove.Correct)
            {
                if(c != ' ')
                    ignore.Add(c);
            }
            foreach(var posList in gameMove.Incorrect)
            {
                foreach(var c in posList)
                {
                    ignore.Add(c);
                }
            }

            foreach(var word in words)
            {
                foreach(var c in word)
                {
                    if (!ignore.Contains(c))
                    {
                        var index = scoreList.FindIndex(ls => ls.Equals(c));
                        if(index == -1)
                        {
                            scoreList.Add(new LetterScore(c, 1));
                        }
                        else
                        {
                            scoreList[index].Inc();
                        }
                    }
                }
            }

            scoreList.Sort();
            LetterScores = scoreList;
        }
    }

    public string ScoredLetters()
    {
        var builder = new StringBuilder();

        foreach(var ls in LetterScores)
        {
            builder.Append(ls.Letter);
        }

        return builder.ToString();
    }
}
