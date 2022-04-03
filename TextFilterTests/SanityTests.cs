using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextFilterTests
{
    [TestClass]
    public class SanityTests
    {
        [TestMethod]
        public void TestEquality()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestInequality()
        {
            Assert.AreNotEqual(1, 2);

        }

        
    }
}