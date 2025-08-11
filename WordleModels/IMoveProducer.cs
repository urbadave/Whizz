namespace WordleModels;

public interface IMoveProducer
{
    string GameId { get; set; }
    int MoveNumber { get; set; }

    GameMove MakeMove2(string textInput);
    UsefulRecords.BoolResponse IsInputValid(string textInput);
    void Instructions();
}