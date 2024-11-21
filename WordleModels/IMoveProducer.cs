namespace WordleModels;

public interface IMoveProducer
{
    string GameId { get; set; }
    int MoveNumber { get; set; }

    GameMove MakeMove(string textInput);
    UsefulRecords.BoolResponse IsInputValid(string textInput);
    void Instructions();
}