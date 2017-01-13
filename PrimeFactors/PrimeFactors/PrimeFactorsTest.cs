using System.Collections.Generic;
using System.Linq;
using static PrimeFactors.PrimeFactors;
using NUnit.Framework;


namespace PrimeFactors
{
    [TestFixture]
    internal class PrimeFactorsTest
    {
        [Test]
        public void TestOne()
        {
            Assert.AreEqual(List(), GeneratePrimes(1));
        }

        [Test]
        public void TestTwo()
        {
            Assert.AreEqual(List(2), GeneratePrimes(2));
        }

        [Test]
        public void TestThree()
        {
            Assert.AreEqual(List(3), GeneratePrimes(3));
        }

        [Test]
        public void TestFour()
        {
            Assert.AreEqual(List(2,2), GeneratePrimes(4));
        }

        [Test]
        public void TestSix()
        {
            Assert.AreEqual(List(2, 3), GeneratePrimes(6));
        }

        [Test]
        public void TestEight()
        {
            Assert.AreEqual(List(2,2,2), GeneratePrimes(8));
        }

        [Test]
        public void TestNine()
        {
            Assert.AreEqual(List(3,3), GeneratePrimes(9));
        }
        private static List<int> List(params int[] primeFactors)
        {
            return primeFactors.ToList();
        }
    }

}
