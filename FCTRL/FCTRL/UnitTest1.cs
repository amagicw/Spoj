using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using FCTRL3;

namespace FCTRL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(120 == Program.Factorial(5));
        }
    }
}
