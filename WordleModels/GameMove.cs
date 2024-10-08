using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace WordleModels;

[DebuggerDisplay("{ToString()}")]
public class GameMove : IEquatable<GameMove>, IComparable<GameMove>
{
    [JsonProperty(PropertyName = "gameId")]
    public string GameId { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "moveNumber")]
    public int MoveNumber { get; set; }

    private List<char> _ruledOut;
    [JsonProperty(PropertyName = "ruledOut")]
    public List<char> RuledOut
    {
        get { return _ruledOut; }
        set { SetRuledOut(value); }
    }

    private List<char> _correct;
    [JsonProperty(PropertyName = "correct")]
    public List<char> Correct { get; set; } = new List<char>();

    [JsonProperty(PropertyName = "incorrect")]
    public List<List<char>> Incorrect { get; set; } = new List<List<char>>();

    public GameMove()
    {
        GameId = Guid.NewGuid().ToString();
    }

    public GameMove(string gameId, int moveNumber, List<char> ruledOut, List<char> correct, List<List<char>> incorrect)
    {
        GameId = (string.IsNullOrEmpty(gameId) ? Guid.NewGuid().ToString() : gameId);
        MoveNumber = moveNumber;
        RuledOut = ruledOut;
        Correct = correct;
        Incorrect = incorrect;
    }


    public void Merge(GameMove other)
    {
        if(other == null) return;

        //add to the ruled out array
        RuledOut = MergeRuledOut(other.RuledOut);

        //update Correct array

        //update the Incorrect array
    }

    private List<char> MergeRuledOut(List<char> ruledOutToAdd)
    {
        var result = new HashSet<char>(this.RuledOut);
        var otherRuledOut = new HashSet<char>(ruledOutToAdd);
        result.UnionWith(otherRuledOut);
        return result.ToList();
    }

    private void SetRuledOut(List<char> value)
    {
        _ruledOut = MakeUniqueUpperLetters(value);
    }

    private List<char> MergeCorrect(List<char> correctToAdd)
    {
        var originalCorrect = this.Correct;
        var newCorrect = CleanCorrect(correctToAdd);
        var mergedCorrect = new List<char>();

        for (var i = 0; i < correctToAdd.Count; i++)
        {
            var oc = originalCorrect[i];
            var nc = newCorrect[i];

            mergedCorrect.Add(oc);
            if(nc != ' ')
            {
                if (mergedCorrect[i] == ' ')
                {
                    mergedCorrect[i] = nc;
                }
                else if (nc != mergedCorrect[i])
                {
                    throw new Exception($"Can't change set letter at {i} from {oc} to {nc}");
                }
            }
        }
        return mergedCorrect;
    }

    private void SetCorrect(List<char> value)
    {
        var upperList = CleanCorrect(value);

        foreach (var c in upperList)
        {
            //can't appear in both ruled out and correct
            if (RuledOut.Contains(c))
            {
                RuledOut.Remove(c);
            }
        }

        _correct = upperList;
    }

    private List<char> CleanCorrect(List<char> correctToClean)
    {
        var emptyList = new List<char>() { ' ', ' ', ' ', ' ', ' ' };

        //accept either length 0 or length 5. nothing else
        List<char> setList;
        if (correctToClean == null || correctToClean.Count == 0) setList = emptyList;
        else if (correctToClean.Count == 5) setList = correctToClean;
        else
        {
            throw new ArgumentException($"Correct list cannot be length {correctToClean.Count}");
        }

        var upperList = new List<char>();
        foreach (var c in setList)
        {
            if (c == ' ' || !char.IsLetter(c))
            {
                upperList.Add(c);
            }
            else
            {
                upperList.Add(char.ToUpper(c));
            }
        }
        return upperList;
    }

    public List<char> MakeUniqueUpperLetters(List<char> value)
    {
        var toPurify = (value == null) ? new List<char>() : value;
        var onlyLetters = new List<char>();
        toPurify.ForEach(c => { if (Char.IsLetter(c)) onlyLetters.Add(c); });

        var allUpper = new List<char>();
        onlyLetters.ForEach(c => allUpper.Add(c.ToString().ToUpper()[0]));
        var uniqueUpper = new HashSet<char>(allUpper);

        return uniqueUpper.ToList();
    }


    public int CompareTo(GameMove? other)
    {
        if(other == null) return 1;

        if(! this.GameId.Equals(other.GameId))
            return this.GameId.CompareTo(other.GameId);

        if(! this.MoveNumber.Equals(other.MoveNumber))
            return this.MoveNumber.CompareTo(other.MoveNumber);

        return 0;
    }

    public bool Equals(GameMove? other)
    {
        if(other == null) return false;

        if (this.GameId.Equals(other.GameId) && this.MoveNumber.Equals(other.MoveNumber))
            return true;

        return false;
    }

    public override string ToString()
    {
        return $"{GameId} [{MoveNumber}]";
    }
}
