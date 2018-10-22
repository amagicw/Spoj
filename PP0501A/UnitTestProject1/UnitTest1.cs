using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestFirstParameterFirstCase()
        {
            PP0501A.Program.Nwd(-1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestFirstParameterSecondCase()
        {
            PP0501A.Program.Nwd(1000001, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestSecondParameterFirstCase()
        {
            PP0501A.Program.Nwd(1, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestSecondParameterSecondCase()
        {
            PP0501A.Program.Nwd(1, 1000001);
        }

        [TestMethod]
        public void TestExample()
        {
            Assert.IsTrue( 1 == PP0501A.Program.Nwd(1, 4));
            Assert.IsTrue( 1 == PP0501A.Program.Nwd(4, 1));
            Assert.IsTrue( 12 == PP0501A.Program.Nwd(12, 48));
            Assert.IsTrue( 4 == PP0501A.Program.Nwd(48, 100));
            Assert.IsTrue( 3 == PP0501A.Program.Nwd(123456, 653421));
        }
    }
}
