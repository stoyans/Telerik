using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrintNameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = _PrintName.PrintName("tan");
            Assert.AreEqual("tan", name);
        }
         [TestMethod]
        public void TestMethod2()
        {
            string name = _PrintName.PrintName("bob");
            Assert.AreEqual("bob", name);
        }
    }
}
