using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextFilterTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreNotEqual(1, 2);

        }
    }
}