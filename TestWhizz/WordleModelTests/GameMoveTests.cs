using WordleModels;

namespace TestWhizz.WordleModelTests;

[TestClass]
public class GameMoveTests
{
    [TestMethod]
    public void DefaultConstructor()
    {
        var model1 = new GameMove();
        var model2 = new GameMove();

        Assert.AreNotEqual(model1, model2);
        Assert.AreEqual(0, model1.MoveNumber);
        Assert.AreEqual(0, model2.MoveNumber);
    }

    [TestMethod]
    public void ModelSorting()
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
}