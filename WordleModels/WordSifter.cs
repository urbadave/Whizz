using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsefulRecords;

namespace WordleModels;
public class WordSifter
{
    public List<string> CommonWords { get; set; } = new List<string>();
    public List<string> CandidateWords { get; set; } = new List<string>();

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
        CandidateWords = possible;
    }

    public List<string> GetWordsWithCorrectLetters(List<char> correct, List<string> words)
    {
        var placedLetters = new List<CorrectLetter>();
        for(var i = 0; i < 5; i++)
        {
            if (correct[i] != ' ')
            {
                placedLetters.Add(new CorrectLetter(correct[i], i));
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
            return CommonWords;
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
            return CommonWords;
        }
    }
}
