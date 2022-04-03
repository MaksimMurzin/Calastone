using System.IO;
using System.Reflection;
using TextFilter;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TextFilterTests
{
    [TestClass]
    public class DataReaderTests
    {

        public string[] CharsToRemove =  new string[] { "@", ",", ".", ";", "'", "`", ":" };
        public string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\test_file.txt");

        [TestMethod]
        public void TestEdgeCase()
        {
            var dataReader = SimpleFactory.GetDataReader(path, CharsToRemove);
            var collection = "out again.The rabbit".Split(" ");
            var correctedCollection = (dataReader as DataReader).EdgeCaseProblem(collection);
            Assert.AreEqual("out again The rabbit", correctedCollection);
        }

    }
}
