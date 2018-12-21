using System;
using PrimeNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberTester
{
    [TestClass]
    public class PrimeNumberTester
    {
        Random RandomIntegerNumberGenerator = new Random();
        Int32 RandomIntegerNumber = new Int32();
        PrimeNumbersApp primeNumber = new PrimeNumbersApp();
        public void Initializer()
        {
            RandomIntegerNumber = RandomIntegerNumberGenerator.Next(0, Int32.MaxValue);
        }
        [TestMethod]
        public void AlgorithmExceptionTest()
        {
            Initializer();
            primeNumber.ForceIntegerNumber(Convert.ToUInt32(RandomIntegerNumber));
            primeNumber.PrimeAlgorithm();
        }
    }
}
