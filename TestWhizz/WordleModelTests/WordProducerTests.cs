using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordleModels;

namespace TestWhizz.WordleModelTests
{
    [TestClass]
    public class WordProducerTests
    {
        [TestMethod]
        public void AllRuledOut()
        {
            var producer = new MoveProducer();

            var move = producer.MakeMove("=S/A/N/E/R/");

            Assert.IsNotNull(move);
            Assert.AreEqual(5, move.RuledOut.Count);
        }

        [TestMethod]
        public void TwoSet()
        {
            var producer = new MoveProducer();
            var sifter = new WordSifter();
            sifter.LoadWords(WordSifterData.fiveLetterWords);

            var move = producer.MakeMove("=S/A/N/E!R!");
            Assert.AreEqual(0, move.MoveNumber);

            Assert.IsNotNull(move);
            Assert.AreEqual(3, move.RuledOut.Count);

            Assert.AreEqual(5, move.Correct.Count);
            Assert.AreEqual('E', move.Correct[3]);
            Assert.AreEqual('R', move.Correct[4]);

            sifter.ApplyGameMove(move);

            var move1 = producer.MakeMove("=L/I!T/E!R!");
            Assert.AreEqual(move.GameId, move1.GameId);
            Assert.AreEqual(1, move1.MoveNumber);

            move.Merge(move1);
            sifter.ApplyGameMove(move);

            Assert.AreEqual(5, move.RuledOut.Count);
            Assert.AreEqual(5, move.Correct.Count);
            Assert.AreEqual('I', move.Correct[1]);
            Assert.AreEqual('E', move.Correct[3]);
            Assert.AreEqual('R', move.Correct[4]);

            var move2 = producer.MakeMove("=V/A/P/I?D/");
            move.Merge(move2);
            sifter.ApplyGameMove(move);

            var move3 = producer.MakeMove("=K/R?A/F?T/");
            move.Merge(move3);
            sifter.ApplyGameMove(move);

            var move4 = producer.MakeMove("=F!I!X/E!R!");
            move.Merge(move4);
            sifter.ApplyGameMove(move);
        }
    }
}
