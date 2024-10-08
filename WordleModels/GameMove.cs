using Newtonsoft.Json;
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

    private List<char> SetRuledOut(List<char> value)
    {
        var allUpper = new List<char>();

        var toPurify = (value == null) ? new List<char>() : value;
        toPurify.ForEach(c => allUpper.Add(c.ToString().ToUpper()[0]));
        var uniqueUpper = new HashSet<char>(allUpper);

        return uniqueUpper.ToList();
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
