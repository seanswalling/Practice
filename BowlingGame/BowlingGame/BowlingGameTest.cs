using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BowlingGame
{
    [TestFixture]
    class BowlingGameTest
    {
        [Test]
        public void TestGutterGame()
        {
            var g = new Game();
            for (var i = 0; i < 20; i++)
            {
                g.roll(0);
            }
            Assert.AreEqual(0, g.score());
        }

        [Test]
        public void TestAllOnes()
        {
            var g = new Game();
            for (var i = 0; i < 20; i++)
            {
                g.roll(1);
            }
            Assert.AreEqual(20, g.score());
        }
    }
}
