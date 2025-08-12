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

    }
}
