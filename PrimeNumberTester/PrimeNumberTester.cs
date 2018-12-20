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
        [TestMethod]
        public void AlgorithmExceptionTest()
        {
            RandomIntegerNumber = RandomIntegerNumberGenerator.Next(0, Int32.MaxValue);
            primeNumber.ForceIntegerNumber(Convert.ToUInt32(RandomIntegerNumber));
        }
    }
}
