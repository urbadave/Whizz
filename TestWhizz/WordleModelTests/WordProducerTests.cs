using Newtonsoft.Json;
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
        public void TestFivePlaceSetClue()
        {
            var producer = new FivePlaceMoveProducer();
            GameMove mergedMove = null;
            var input = "-0 O2 -0 -0 S2";
            var move = producer.MakeMove(input);
            var thing = JsonConvert.SerializeObject(move);

            Assert.AreEqual('O', move.Correct[1]);
            Assert.AreEqual('S', move.Correct[4]);
        }

        [TestMethod]
        public void TestFivePlaceThreeRuledOut()
        {
            var producer = new FivePlaceMoveProducer();
            GameMove mergedMove = null;
            var input = "R0 T0 I0 -0 -0";
            var move = producer.MakeMove(input);
            var thing = JsonConvert.SerializeObject(move);

            Assert.AreEqual(3, move.RuledOut.Count);
        }

        [TestMethod]
        public void TestFivePlaceSlims()
        {
            var producer = new FivePlaceMoveProducer();
            GameMove mergedMove = null;
            var input = "A0 R0 O0 S1 E0";
            var move = producer.MakeMove(input);

            Assert.IsNotNull(move);
            Assert.AreEqual(4, move.RuledOut.Count);
            var thing = JsonConvert.SerializeObject(move);
            mergedMove = move;
            var mergedThing = JsonConvert.SerializeObject(mergedMove);

            input = "U0 N0 T0 I1 L1";
            move = producer.MakeMove(input);
            thing = JsonConvert.SerializeObject(move);
            mergedMove.Merge(move);
            mergedThing = JsonConvert.SerializeObject(mergedMove);

            input = "M1 U0 C0 K0 Y0";
            move = producer.MakeMove(input);
            thing = JsonConvert.SerializeObject(move);
            mergedMove.Merge(move);
            mergedThing = JsonConvert.SerializeObject(mergedMove);

            input = "F0 L2 I2 P0 S2";
            move = producer.MakeMove(input);
            thing = JsonConvert.SerializeObject(move);
            mergedMove.Merge(move);
            mergedThing = JsonConvert.SerializeObject(mergedMove);
        }

        [TestMethod]
        public void TestFivePlaceGofer()
        {
            var producer = new FivePlaceMoveProducer();
            GameMove mergedMove = null;
            var input = "A0 R1 O1 S0 E1";
            var move = producer.MakeMove(input);
            Assert.IsNotNull(move);
            Assert.AreEqual(2, move.RuledOut.Count);
            var thing = JsonConvert.SerializeObject(move);
            mergedMove = move;
            var mergedThing = JsonConvert.SerializeObject(mergedMove);

            input = "B0 U0 N0 D0 T0";
            move = producer.MakeMove(input);
            thing = JsonConvert.SerializeObject(move);
            mergedMove.Merge(move);
            mergedThing = JsonConvert.SerializeObject(mergedMove);

            input = "C0 L0 U0 M0 P0";
            move = producer.MakeMove(input);
            thing = JsonConvert.SerializeObject(move);
            mergedMove.Merge(move);
            mergedThing = JsonConvert.SerializeObject(mergedMove);

            input = "W0 A0 K0 F1 S0";
            move = producer.MakeMove(input);
            thing = JsonConvert.SerializeObject(move);
            mergedMove.Merge(move);
            mergedThing = JsonConvert.SerializeObject(mergedMove);

            input = "O1 F0 F2 E2 R2";
            move = producer.MakeMove(input);
            thing = JsonConvert.SerializeObject(move);
            mergedMove.Merge(move);
            mergedThing = JsonConvert.SerializeObject(mergedMove);
        }

        [TestMethod]
        public void AllRuledOut()
        {
            var producer = new FivePlaceMoveProducer();

            var move = producer.MakeMove2("=S/A/N/E/R/");

            Assert.IsNotNull(move);
            Assert.AreEqual(5, move.RuledOut.Count);
        }

        [TestMethod]
        public void TwoSet()
        {
            var producer = new FivePlaceMoveProducer();
            var sifter = new WordSifter();
            sifter.LoadWords(WordSifterData.fiveLetterWords);

            var move = producer.MakeMove2("=S/A/N/E!R!");
            Assert.AreEqual(0, move.MoveNumber);

            Assert.IsNotNull(move);
            Assert.AreEqual(3, move.RuledOut.Count);

            Assert.AreEqual(5, move.Correct.Count);
            Assert.AreEqual('E', move.Correct[3]);
            Assert.AreEqual('R', move.Correct[4]);

            sifter.ApplyGameMove(move);

            var move1 = producer.MakeMove2("=L/I!T/E!R!");
            Assert.AreEqual(move.GameId, move1.GameId);
            Assert.AreEqual(1, move1.MoveNumber);

            move.Merge(move1);
            sifter.ApplyGameMove(move);

            Assert.AreEqual(5, move.RuledOut.Count);
            Assert.AreEqual(5, move.Correct.Count);
            Assert.AreEqual('I', move.Correct[1]);
            Assert.AreEqual('E', move.Correct[3]);
            Assert.AreEqual('R', move.Correct[4]);

            var move2 = producer.MakeMove2("=V/A/P/I?D/");
            move.Merge(move2);
            sifter.ApplyGameMove(move);

            var move3 = producer.MakeMove2("=K/R?A/F?T/");
            move.Merge(move3);
            sifter.ApplyGameMove(move);

            var move4 = producer.MakeMove2("=F!I!X/E!R!");
            move.Merge(move4);
            sifter.ApplyGameMove(move);
        }
    }
}
