using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleModels;
public class WordScore: IComparable<WordScore>
{
    public string Word { get; set; }
    public int Score { get; set; }

    public WordScore()
    {
        Word = string.Empty;
        Score = 0;
    }

    public WordScore(string word)
    {
        Word = word;
        Score = 0;
    }

    public void SetScore(List<LetterScore> letterScores)
    {
        Score = 0;
        foreach (var ls in letterScores)
        {
            if (Word.Contains(ls.Letter))
            {
                Score += ls.Score;
            }
        }
    }

    public int CompareTo(WordScore? other)
    {
        if(other == null) return -11;
        if(Score == other.Score)
        {
            return other.Word.CompareTo(Word);
        }
        return other.Score.CompareTo(Score);
    }

    public override string ToString()
    {
        return $"{Word}:{Score}";
    }
}
