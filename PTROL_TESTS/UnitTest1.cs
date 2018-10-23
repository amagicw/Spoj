using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTROL_ROL;

namespace PTROL_TESTS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.Ptrol("7 1 2 3 4 5 6 7") == "2 3 4 5 6 7 1");
            Assert.IsTrue(Program.Ptrol("3 2 1 10") == "1 10 2");
        }
    }
}
