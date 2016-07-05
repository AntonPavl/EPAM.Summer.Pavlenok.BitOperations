using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitMath;


namespace BitMathTests
{
    [TestClass]
    public class BitMathTest
    {

        [TestMethod]
        public void ComputeSign_100_0()
        {
            int a = 100;
            double expectedResult = 0;
            double realResult = BitAlghoritm.ComputeSign(a);
            Assert.AreEqual(expectedResult, realResult);
        }
        [TestMethod]
        public void ComputeSign_Negative100_1()
        {
            int a = -100;
            double expectedResult = 1;
            double realResult = BitAlghoritm.ComputeSign(a);
            Assert.AreEqual(expectedResult, realResult);
        }
        [TestMethod]
        public void ComputeValue_10andNegative10_1()
        {
            int a = 10;
            int b = -10;
            double expectedResult = a;
            double realResult = BitAlghoritm.ComputeValue(a, b);
            Assert.AreEqual(expectedResult, realResult);
        }
        [TestMethod]
        public void ComputeValue_Negative10andNegative10_negative1()
        {
            int a = -10;
            int b = -10;
            double expectedResult = 1;
            double realResult = BitAlghoritm.ComputeValue(a, b);
            Assert.AreEqual(expectedResult, realResult);
        }
        [TestMethod]
        public void ComputeValue_1626436andNegative14125363_0()
        {
            int a = 1626436;
            int b = 14125363;
            double expectedResult = b;
            double realResult = BitAlghoritm.ComputeValue(a, b);
            Assert.AreEqual(expectedResult, realResult);
        }
    }
}
