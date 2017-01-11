using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace PrimeFactors
{
    [TestFixture]
    class PrimeFactorsTest
    {
        private List<int> List(params int[] ints)
        {
            List<int> List = new List<int>();
            foreach (int i in ints)
            {
                List.Add(i);
            }
            return List;
        }

        [Test]
        public void TestOne()
        {
            Assert.AreEqual(List(), PrimeFactors.Generate(1));
        }

        [Test]
        public void TestTwo()
        {
            Assert.AreEqual(List(2), PrimeFactors.Generate(2));
        }

        [Test]
        public void TestThree()
        {
            Assert.AreEqual(List(3), PrimeFactors.Generate(3));
        }

        [Test]
        public void TestFour()
        {
            Assert.AreEqual(List(2,2), PrimeFactors.Generate(4));
        }

        [Test]
        public void TestSix()
        {
            Assert.AreEqual(List(2,3), PrimeFactors.Generate(6));
        }
    }

}
