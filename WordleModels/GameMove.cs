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

    private List<char> _correct;
    [JsonProperty(PropertyName = "correct")]
    public List<char> Correct
    {
        get { return _correct; }
        set { SetCorrect(value); }
    }

    private List<List<char>> _incorrect;
    [JsonProperty(PropertyName = "incorrect")]
    public List<List<char>> Incorrect
    {
        get { return _incorrect; }        
        set { SetIncorrect(value); }
    }

    public GameMove()
    {
        GameId = Guid.NewGuid().ToString();
        RuledOut = new List<char>();
        Correct = new List<char>();
        Incorrect = new List<List<char>>();
    }

    public GameMove(string gameId)
    {
        GameId = gameId;
        RuledOut = new List<char>();
        Correct = new List<char>();
        Incorrect = new List<List<char>>();
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

        //validation rules:
        var canMerge = CanMerge(other);

        if (canMerge.response == true)
        {
            //add to the ruled out array
            RuledOut = MergeRuledOut(other.RuledOut);

            //update Correct array
            Correct = MergeCorrect(other.Correct);

            //update the Incorrect array
            Incorrect = MergeIncorrect(other.Incorrect);

            //update game move
            MoveNumber = other.MoveNumber;
        }
        else
        {
            throw new ArgumentException(canMerge.message);
        }
    }

    public UsefulRecords.BoolResponse CanMerge(GameMove? other)
    {
        if (other == null)
            return new UsefulRecords.BoolResponse(false, "Cannot merge with null");

        if (other.GameId != GameId)
            return new UsefulRecords.BoolResponse(false, "GameIds do not match");

        if ((MoveNumber + 1) != other.MoveNumber)
            return new UsefulRecords.BoolResponse(false, $"Cannot merge move {other.MoveNumber} into move {MoveNumber}");

        return new UsefulRecords.BoolResponse(true, string.Empty);
    }

    public string ToJson()
    {
        var retVal = JsonConvert.SerializeObject(this);

        if (retVal == null)
            throw new Exception("Could not serialize into JSON");

        return retVal;
    }

    public int CompareTo(GameMove? other)
    {
        if (other == null) return 1;

        if (!this.GameId.Equals(other.GameId))
            return this.GameId.CompareTo(other.GameId);

        if (!this.MoveNumber.Equals(other.MoveNumber))
            return this.MoveNumber.CompareTo(other.MoveNumber);

        return 0;
    }

    public bool Equals(GameMove? other)
    {
        if (other == null) return false;

        if (this.GameId.Equals(other.GameId) && this.MoveNumber.Equals(other.MoveNumber))
            return true;

        return false;
    }

    public override string ToString()
    {
        return $"{GameId} [{MoveNumber}]";
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
        var clean = MakeUniqueUpperLetters(value);
        clean.Sort();
        _ruledOut = clean;
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
                mergedCorrect[i] = nc;
            }
        }
        return mergedCorrect;
    }

    private void SetCorrect(List<char> value)
    {
        var upperList = CleanCorrect(value);
        if (upperList.Count != 5) upperList = new List<char> { ' ', ' ', ' ', ' ', ' ' };

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
        if (correctToClean == null || correctToClean.Count != 5)
            setList = emptyList;
        else 
            setList = correctToClean;

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

    private List<List<char>> MergeIncorrect(List<List<char>> incorrectToAdd)
    {
        var cleanToAdd = CleanIncorrect(incorrectToAdd);
        var merged = new List<List<char>>();
        for (var i = 0; i < 5; i++)
        {
            HashSet<char> positionHash = new HashSet<char>(Incorrect[i]);
            positionHash.UnionWith(cleanToAdd[i]);
            List<char> positionList = positionHash.ToList();
            positionList.Sort();
            merged.Add(positionList);
        }
        return merged;
    }

    private void SetIncorrect(List<List<char>> value)
    {
        var toAssign = CleanIncorrect(value);

        for(var i = 0; i < 5; i++)
        {
            toAssign[i].ForEach(c => { if (RuledOut.Contains(c)) RuledOut.Remove(c); });
        }

        _incorrect = toAssign;
    }

    private List<List<char>> CleanIncorrect(List<List<char>> value)
    {
        var cleaned = new List<List<char>>();

        if (value != null)
        {
            for (var i = 0; i < 5; i++)
            {
                if (value.Count > i)
                {
                    var cleanAdd = MakeUniqueUpperLetters(value[i]);
                    cleaned.Add(cleanAdd);
                }
                else
                {
                    cleaned.Add(new List<char>());
                }
            }
        }
        return cleaned;
    }

    private List<char> MakeUniqueUpperLetters(List<char> value)
    {
        var toPurify = (value == null) ? new List<char>() : value;
        var onlyLetters = new List<char>();
        toPurify.ForEach(c => { if (Char.IsLetter(c)) onlyLetters.Add(c); });

        var allUpper = new List<char>();
        onlyLetters.ForEach(c => allUpper.Add(c.ToString().ToUpper()[0]));
        var uniqueUpper = new HashSet<char>(allUpper);

        return uniqueUpper.ToList();
    }

}
