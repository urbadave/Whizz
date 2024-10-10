using Newtonsoft.Json;
using WordleModels;

namespace TestWhizz.WordleModelTests;

[TestClass]
public class WordSifterTests
{
    [TestMethod]
    public void LoadWordsTest()
    {
        var sifter = new WordSifter();
        sifter.LoadWords(WordSifterData.fiveLetterWords);

        Assert.AreEqual(3846, sifter.CommonWords.Count);
    }

    [TestMethod]
    public void GetPossibleWord_NotRuledOut()
    {
        var ruledOut1 = new List<char> { 'C', 'E', 'M', 'N', 'P', 'R', 'S', 'T' };
        var ruledOut2 = new List<char> { 'B', 'F', 'G', 'L', 'N', 'S', 'Y' };

        var sifter = new WordSifter();
        sifter.LoadWords(WordSifterData.fiveLetterWords);
        var notImpossible = sifter.GetNotRuledOutWords(ruledOut1, sifter.CommonWords);

        Assert.IsNotNull(notImpossible);
        Assert.AreEqual(140, notImpossible.Count);

        notImpossible = sifter.GetNotRuledOutWords(ruledOut2, sifter.CommonWords);
        Assert.IsNotNull(notImpossible);
        Assert.AreEqual(566, notImpossible.Count);
    }

    [TestMethod]
    public void GetPossibleWords_PlacedLetters()
    {
        var placed1 = new List<char> { ' ', 'A', 'R', ' ', 'E' };
        var placed2 = new List<char> { ' ', ' ', 'H', ' ', ' ' };

        var sifter = new WordSifter();
        sifter.LoadWords(WordSifterData.fiveLetterWords);
        var notImpossible = sifter.GetWordsWithCorrectLetters(placed1, sifter.CommonWords);

        Assert.IsNotNull(notImpossible);
        Assert.AreEqual(9, notImpossible.Count);

        notImpossible = sifter.GetWordsWithCorrectLetters(placed2, sifter.CommonWords);

        Assert.IsNotNull(notImpossible);
        Assert.AreEqual(23, notImpossible.Count);
    }

    [TestMethod]
    public void ApplyGameMoveTest_AccumulateMove()
    {
        var sifter = new WordSifter();
        sifter.LoadWords(WordSifterData.fiveLetterWords);
        var move1 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model1Json);
        var gameMove = move1;
        sifter.ApplyGameMove(gameMove);
        var result = sifter.CandidateWords;
        Assert.IsNotNull(result);
        Assert.AreEqual(171, result.Count);

        sifter = new WordSifter();
        sifter.LoadWords(WordSifterData.fiveLetterWords);
        move1 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model1Json);
        var move2 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model2Json);
        gameMove = move1;
        gameMove.Merge(move2);
        sifter.ApplyGameMove(gameMove);
        result = sifter.CandidateWords;
        Assert.IsNotNull(result);
        Assert.AreEqual(17, result.Count);

        sifter = new WordSifter();
        sifter.LoadWords(WordSifterData.fiveLetterWords);
        move1 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model1Json);
        move2 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model2Json);
        var move3 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model3Json);
        gameMove = move1;
        gameMove.Merge(move2);
        gameMove.Merge(move3);
        sifter.ApplyGameMove(gameMove);
        result = sifter.CandidateWords;
        Assert.IsNotNull(result);
        Assert.AreEqual(3, result.Count);

        sifter = new WordSifter();
        sifter.LoadWords(WordSifterData.fiveLetterWords);
        move1 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model1Json);
        move2 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model2Json);
        move3 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model3Json);
        var move4 = JsonConvert.DeserializeObject<GameMove>(GameMoveTestData.model4Json);
        gameMove = move1;
        gameMove.Merge(move2);
        gameMove.Merge(move3);
        gameMove.Merge(move4);
        sifter.ApplyGameMove(gameMove);
        result = sifter.CandidateWords;
        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);
    }
}
