using Microsoft.VisualStudio.TestTools.UnitTesting;
using POTSAM;

namespace POTSAM_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.Calculate(2, 5, 3, 20) == 70);
        }

        [TestMethod]
        public void CheckCases()
        {
            Assert.IsTrue(Program.Check(1));
            Assert.IsTrue(Program.Check(1000));
            Assert.IsFalse(Program.Check(0));
            Assert.IsFalse(Program.Check(10001));
        }
    }
}
