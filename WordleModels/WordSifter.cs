using System.Text;
using UsefulRecords;

namespace WordleModels;
public class WordSifter
{
    public List<string> CommonWords { get; set; } = new List<string>();
    public List<string> CandidateWords { get; set; } = new List<string>();
    public List<LetterScore> LetterScores { get; set; } = new List<LetterScore>();
    public List<WordScore> BestGuesses { get; set; } = new List<WordScore>();
    public List<WordScore> RuleOuts { get; set; } = new List<WordScore>();

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

        var scoredWords = ScoreWords();
        BestGuesses.Clear();
        BestGuesses.AddRange(scoredWords.Take(5));
        //var count = 0;
        //while(count < scoredWords.Count && count < 5)
        //{
        //    BestGuesses.Add(scoredWords[count]);
        //    count++;
        //}
        var ruleOutGuess = ScoreAllWords();
        RuleOuts.Clear();
        RuleOuts.AddRange(ruleOutGuess.Take(5));
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
            List<string> possible = new();

            foreach (var word in words)
            {
                //word must contain ALL misplaced letters
                var impossible = false;
                foreach(var pl in misplacedLetters)
                {
                    if(!word.Contains(pl.letter))
                        impossible = true;
                }
                if (impossible) continue;

                //now make sure word doesn't contain any letters in the wrong place.
                foreach(var pl in misplacedLetters)
                {
                    if (word[pl.position] == pl.letter)
                    {
                        impossible = true;
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
        //return builder.ToString();
        List<string> outList = new();
        foreach(var ls in LetterScores)
        {
            outList.Add(ls.ToString());
        }
        if (outList.Any())
            return string.Join(", ", outList);
        else
            return string.Empty;
    }

    public List<WordScore> ScoreWords()
    {
        List<WordScore> outList = new();

        foreach(var word in CandidateWords)
        {
            var toAdd = new WordScore(word);
            toAdd.SetScore(LetterScores);
            outList.Add(toAdd);
        }
        outList.Sort();
        return outList;
    }

    public List<WordScore> ScoreAllWords()
    {
        List<WordScore> outList = new();

        foreach (var word in CommonWords)
        {
            var toAdd = new WordScore(word);
            toAdd.SetScore(LetterScores);
            outList.Add(toAdd);
        }
        outList.Sort();
        var retVal = outList.Take(10).ToList();
        return retVal;
    }
}
