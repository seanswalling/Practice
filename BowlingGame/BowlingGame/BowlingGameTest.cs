using NUnit.Framework;

namespace BowlingGame
{
    [TestFixture]
    internal class BowlingGameTest
    {
        private Game _g;
        [SetUp]
        protected void SetUp()
        {
            _g = new Game();
        }

        [Test]
        public void TestGutterGame()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, _g.Score());
        }

        [Test]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, _g.Score());
        }

        [Test]
        public void TestOneSpare()
        {
            RollSpare();
            _g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, _g.Score());
        }

        [Test]
        public void TestOneStrike()
        {
            RollStrike();
            _g.Roll(3);
            _g.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, _g.Score());
        }

        [Test]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, _g.Score());    
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; i++)
            {
                _g.Roll(pins);
            }
        }

        private void RollSpare()
        {
            _g.Roll(5);
            _g.Roll(5);
        }

        private void RollStrike()
        {
            _g.Roll(10);
        }
    }
}
