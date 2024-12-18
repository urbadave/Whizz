using Newtonsoft.Json;
using WordleModels;

namespace TestWhizz.WordleModelTests;

[TestClass]
public class GameMoveTests
{
    [TestMethod]
    public void DefaultConstructorAndEquatable_Works()
    {
        var model1 = new GameMove(Guid.NewGuid().ToString());
        var model2 = new GameMove(Guid.NewGuid().ToString());

        Assert.AreNotEqual(model1, model2);
        Assert.AreEqual(0, model1.MoveNumber);
        Assert.AreEqual(0, model2.MoveNumber);
        Assert.AreEqual(0, model1.RuledOut.Count);
        Assert.AreEqual(5, model1.Correct.Count);
        Assert.AreEqual(5, model1.Incorrect.Count);

        var model3 = new GameMove("f68e81a4-a0df-424c-9621-a84156be228b", 0, new(), new(), new());
        var model4 = new GameMove("f68e81a4-a0df-424c-9621-a84156be228b", 0, new(), new(), new());
        Assert.AreEqual(model3, model4);
    }

    [TestMethod]
    public void EqualityTests()
    {
        var model1 = new GameMove("e168a3fb-bab7-4317-9136-e8a68cd750c1", 0, new(), new(), new());
        var model2 = new GameMove("e168a3fb-bab7-4317-9136-e8a68cd750c1", 1, new(), new(), new());
        var model3 = new GameMove("f68e81a4-a0df-424c-9621-a84156be228b", 0, new(), new(), new());
        var model4 = new GameMove("f68e81a4-a0df-424c-9621-a84156be228b", 1, new(), new(), new());

        var sortList = new List<GameMove>() { model4, model1, model3, model2 };
        sortList.Sort();
        Assert.AreEqual(model1, sortList[0]);
        Assert.AreEqual(model2, sortList[1]);
        Assert.AreEqual(model3, sortList[2]);
        Assert.AreEqual(model4, sortList[3]);
    }

    [TestMethod]
    public void CanMergeTests()
    {
        var model1 = new GameMove("e168a3fb-bab7-4317-9136-e8a68cd750c1", 0, new(), new(), new());
        var model2 = new GameMove("e168a3fb-bab7-4317-9136-e8a68cd750c1", 1, new(), new(), new());
        var model3 = new GameMove("f68e81a4-a0df-424c-9621-a84156be228b", 0, new(), new(), new());
        var model4 = new GameMove("f68e81a4-a0df-424c-9621-a84156be228b", 1, new(), new(), new());

        var response1 = model1.CanMerge(model2);
        Assert.IsTrue(response1.response);

        var response2 = model1.CanMerge(model3);
        Assert.IsFalse(response2.response);

        var response3 = model2.CanMerge(model1);
        Assert.IsFalse(response3.response);

        var response4 = model4.CanMerge(null);
        Assert.IsFalse(response4.response);
    }

    [TestMethod]
    public void RuledOutAsignment_UpperCaseLettersOnlySorted()
    {
        var model1 = new GameMove(Guid.NewGuid().ToString());
        var testData1 = new List<char> { 'A', 'a', 'r', 'X' };
        var testData2 = new List<char> { 'A', 'a', 'r', 'X', '~', '|', '&', 'm' };

        model1.RuledOut = testData1;
        Assert.AreEqual(3, model1.RuledOut.Count);
        Assert.IsTrue(model1.RuledOut.Contains('A'));
        Assert.IsTrue(model1.RuledOut.Contains('R'));
        Assert.IsFalse(model1.RuledOut.Contains('r'));
        Assert.IsTrue(model1.RuledOut.Contains('X'));

        var model2 = new GameMove(Guid.NewGuid().ToString()) { RuledOut = testData1 };
        Assert.AreEqual(3, model2.RuledOut.Count);
        Assert.IsTrue(model2.RuledOut.Contains('A'));
        Assert.IsTrue(model2.RuledOut.Contains('R'));
        Assert.IsFalse(model2.RuledOut.Contains('r'));
        Assert.IsTrue(model2.RuledOut.Contains('X'));

        var model3 = new GameMove("e168a3fb-bab7-4317-9136-e8a68cd750c1", 0, testData1, new(), new());
        Assert.AreEqual(3, model3.RuledOut.Count);
        Assert.IsTrue(model3.RuledOut.Contains('A'));
        Assert.IsTrue(model3.RuledOut.Contains('R'));
        Assert.IsFalse(model3.RuledOut.Contains('r'));
        Assert.IsTrue(model3.RuledOut.Contains('X'));

        var model4 = new GameMove("e168a3fb-bab7-4317-9136-e8a68cd750c1", 0, new(), new(), new());
        Assert.AreEqual(0, model4.RuledOut.Count);

        var model5 = new GameMove(Guid.NewGuid().ToString()) { RuledOut = testData2 };
        Assert.AreEqual(4, model5.RuledOut.Count);
        Assert.IsTrue(model5.RuledOut.Contains('A'));
        Assert.IsTrue(model5.RuledOut.Contains('R'));
        Assert.IsFalse(model5.RuledOut.Contains('r'));
        Assert.IsTrue(model5.RuledOut.Contains('X'));
        Assert.IsTrue(model5.RuledOut.Contains('M'));
    }

    [TestMethod]
    public void CorrectRemovesRuledOut()
    {
        var ruledOut1 = new List<char> { 'S', 'A', 'E' };
        var correct1 = new List<char> { 'S', ' ', ' ', ' ', ' ', };

        var model1 = new GameMove("e168a3fb-bab7-4317-9136-e8a68cd750c1", 0, new(), new(), new());
        Assert.AreEqual(0, model1.RuledOut.Count);
        Assert.AreEqual(5, model1.Correct.Count);
        Assert.AreEqual(' ', model1.Correct[0]);

        model1.RuledOut = ruledOut1;
        Assert.AreEqual(3, model1.RuledOut.Count);
        Assert.AreEqual(5, model1.Correct.Count);
        Assert.AreEqual(' ', model1.Correct[0]);

        model1.Correct = correct1;
        Assert.AreEqual(2, model1.RuledOut.Count);
        Assert.AreEqual(5, model1.Correct.Count);
        Assert.AreEqual('S', model1.Correct[0]);
    }


    [TestMethod]
    public void MergeTest_Normal()
    {
        var move1 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model1Json);
        var move2 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model2Json);
        var move3 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model3Json);
        var move4 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model4Json);

        var gameId = move1.GameId;
        var gameMove = move1;
        Assert.AreEqual(gameId, gameMove.GameId);
        Assert.AreEqual(2, gameMove.RuledOut.Count);
        Assert.AreEqual(' ', gameMove.Correct[0]);
        Assert.AreEqual('A', gameMove.Correct[1]);
        Assert.AreEqual('E', gameMove.Incorrect[3][0]);
        Assert.AreEqual('R', gameMove.Incorrect[4][0]);

        gameMove.Merge(move2);
        Assert.AreEqual(4, gameMove.RuledOut.Count);
        Assert.AreEqual(' ', gameMove.Correct[0]);
        Assert.AreEqual('A', gameMove.Correct[1]);
        Assert.AreEqual('R', gameMove.Correct[2]);
        Assert.AreEqual('E', gameMove.Incorrect[3][0]);
        Assert.AreEqual('R', gameMove.Incorrect[4][0]);
        Assert.AreEqual('E', gameMove.Incorrect[0][0]);

        gameMove.Merge(move3);
        Assert.AreEqual(6, gameMove.RuledOut.Count);
        Assert.AreEqual(' ', gameMove.Correct[0]);
        Assert.AreEqual('A', gameMove.Correct[1]);
        Assert.AreEqual('R', gameMove.Correct[2]);
        Assert.AreEqual('E', gameMove.Correct[4]);
        Assert.AreEqual('E', gameMove.Incorrect[3][0]);
        Assert.AreEqual('R', gameMove.Incorrect[4][0]);
        Assert.AreEqual('E', gameMove.Incorrect[0][0]);

        gameMove.Merge(move4);
        Assert.AreEqual(7, gameMove.RuledOut.Count);
        Assert.AreEqual(' ', gameMove.Correct[0]);
        Assert.AreEqual('A', gameMove.Correct[1]);
        Assert.AreEqual('R', gameMove.Correct[2]);
        Assert.AreEqual('E', gameMove.Correct[4]);
        Assert.AreEqual('C', gameMove.Incorrect[3][0]);
        Assert.AreEqual('R', gameMove.Incorrect[4][0]);
        Assert.AreEqual('E', gameMove.Incorrect[0][0]);
        Assert.AreEqual('E', gameMove.Incorrect[3][1]);
    }


}