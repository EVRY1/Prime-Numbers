using System;
using PrimeNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberTester
{
    [TestClass]
    public class PrimeNumberTester
    {
        PrimeNumbersApp primeNumber = new PrimeNumbersApp();
        [TestMethod]
        public void AlgorithmTest()
        {
            Assert.IsFalse(primeNumber.PrimeAlgorithm(21));
            Assert.IsTrue(primeNumber.PrimeAlgorithm(97));
        }
    }
}
