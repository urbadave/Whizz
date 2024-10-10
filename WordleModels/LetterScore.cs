

using System.Text;

namespace WordleModels;
public class LetterScore: IEquatable<char>, IEquatable<LetterScore>, IComparable<LetterScore>
{
    public char Letter { get; set; }
    public int Score { get; set; }

    public LetterScore(char letter, int score)
    {
        Letter = letter;
        Score = score;
    }

    public void Inc()
    {
        Score++;
    }

    public int CompareTo(LetterScore? other)
    {
        if(other == null) return 1;
        if (Score.Equals(other.Score))
        {
            return Letter.CompareTo(other.Letter);
        }
        else
        {
            return other.Score.CompareTo(Score);
        }
    }

    public bool Equals(LetterScore? other)
    {
        if(other == null) return false;
        if(Letter.Equals(other.Letter)) return true;

        return false;
    }

    public bool Equals(char other)
    {
        return Letter.Equals(other);
    }
}
