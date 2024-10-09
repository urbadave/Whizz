using WordleModels;

namespace TestWhizz.WordleModelTests;

[TestClass]
public class GameMoveTests
{
    [TestMethod]
    public void DefaultConstructorAndEquatable_Works()
    {
        var model1 = new GameMove();
        var model2 = new GameMove();

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
    public void RuledOut_UpperCaseAndSorted()
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
    public void RuledOutAsignment_UpperCaseLettersOnlySorted()
    {
        var model1 = new GameMove();
        var testData1 = new List<char> { 'A', 'a', 'r', 'X' };
        var testData2 = new List<char> { 'A', 'a', 'r', 'X', '~', '|', '&', 'm' };

        model1.RuledOut = testData1;
        Assert.AreEqual(3, model1.RuledOut.Count);
        Assert.IsTrue(model1.RuledOut.Contains('A'));
        Assert.IsTrue(model1.RuledOut.Contains('R'));
        Assert.IsFalse(model1.RuledOut.Contains('r'));
        Assert.IsTrue(model1.RuledOut.Contains('X'));

        var model2 = new GameMove() { RuledOut = testData1 };
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

        var model5 = new GameMove() { RuledOut = testData2 };
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
}