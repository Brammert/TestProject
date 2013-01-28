using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SampleClassLibrary;

namespace SampleUnitTestProject
{
    [TestClass]
    public class MyClassTest
    {
        [TestMethod]
        public void TestDoMagic()
        {
            int expected = 3;
            int actual = MyClass.DoMagic(1, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
