using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNumberInArray
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 3, 3, 3, 4, 7 };
            int result = NumberInArray.findNum(array, 3);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 3, 3, 3, 4, 7 };
            int result = NumberInArray.findNum(array, 7);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 3, 3, 3, 4, 7 };
            int result = NumberInArray.findNum(array, 4);
            Assert.AreEqual(1, result);
        }
    }
}
