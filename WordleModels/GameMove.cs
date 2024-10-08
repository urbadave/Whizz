using Newtonsoft.Json;

namespace WordleModels;

public class GameMove
{
    [JsonProperty(PropertyName = "gameId")]
    public string GameId { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "moveNumber")]
    public int MoveNumber { get; set; }

    [JsonProperty(PropertyName = "ruledOut")]
    public List<string> RuledOut { get; set; } = new List<string>();

    [JsonProperty(PropertyName = "correct")]
    public List<string> Correct { get; set; } = new List<string>();

    [JsonProperty(PropertyName = "incorrect")]
    public List<List<string>> Incorrect { get; set; } = new List<List<string>>();


}
