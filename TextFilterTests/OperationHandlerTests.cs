using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilterTests
{

    [TestClass]
    public class OperationHandlerTests
    {
        [TestMethod]
        [DataRow("middle", 3, false)]
        [DataRow("the", 4, true)]
        [DataRow("Alice", 5, false)]
        public void IsWordShorterThan(string testWord, int length, bool expectedOutcome)
        {
            Assert.AreEqual(OperationHandler.IsWordShorterThan(testWord, length), expectedOutcome);
        }

        [TestMethod]
        [DataRow("really", "R", false)]
        [DataRow("really,", ",", true)]
        public void TestDoesWordContainChar(string word, string character, bool expectedOutcome)
        {
            Assert.AreEqual(OperationHandler.DoesWordContainChar(word, character), expectedOutcome);
        }

        [TestMethod]
        [DataRow("clean", "e")]
        [DataRow("currently", "e")]
        [DataRow("what", "ha")]
        public void TestGetMiddleChar(string word, string middleChar)
        {
            Assert.AreEqual(OperationHandler.GetMiddleChar(word), middleChar);
        }

        [TestMethod]
        [DataRow("clean", new char[] { 'e' }, true)]
        [DataRow("currently", new char[] { 'e' }, true)]
        [DataRow("what", new char[] { ',' }, false)]
        public void TestWordHasCharsInTheMiddle(string word, IEnumerable<char> offendingChars, bool expectedOutcome)
        {
            Assert.AreEqual(OperationHandler.WordHasCharsInMiddle(word, offendingChars), expectedOutcome);

        }

        [TestMethod]
        [DataRow(new string[]{ "and", "of", "having", "nothing", "to", "do" } ) ]
        public void TestFilterWordsWith(IEnumerable<string> wordCollection)
        {
            var filteredWords = OperationHandler.FilterWordsWith(wordCollection, OperationHandler.IsWordLongerOrEqualTo, 3);

            Assert.AreEqual(filteredWords.ToList().ToString(), new List<string> { "and","having", "nothing" }.ToString());

        }

    }
}
