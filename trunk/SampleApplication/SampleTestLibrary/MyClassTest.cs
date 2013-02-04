using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using SampleClassLibrary;

namespace SampleTestLibrary
{
    [TestFixture] 
    public class MyClassTest
    {
        [Test]
        public void MyAddTest()
        {
            Assert.AreEqual(MyClass.DoMagic(2, 3), 5);
        }
    }
}
