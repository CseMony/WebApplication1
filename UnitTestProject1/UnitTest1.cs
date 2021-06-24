using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
                //Arrange:Initialize objects. Creates an instance of the class
                UnitTestClass tp = new UnitTestClass();
                //assert part
                Assert.AreEqual(tp.Name, "Unit Testing");
            
        }
    }
}
