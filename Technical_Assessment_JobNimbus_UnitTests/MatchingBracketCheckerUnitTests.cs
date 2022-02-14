using Technical_Assessment_JobNimbus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Technical_Assessment_JobNimbus_UnitTests
{
    [TestClass]
    public class MatchingBracketCheckerUnitTests
    {
        [TestMethod]
        public void TestString1()
        {
            var bracketChecker = new MatchingBracketChecker("{}");
            var expected = true;
            Assert.AreEqual(bracketChecker.HasMatchingBrackets, expected);
        }
        [TestMethod]
        public void TestString2()
        {
            var bracketChecker = new MatchingBracketChecker("}{");
            var expected = false;
            Assert.AreEqual(bracketChecker.HasMatchingBrackets, expected);
        }
        [TestMethod]
        public void TestString3()
        {
            var bracketChecker = new MatchingBracketChecker("{{}");
            var expected = false;
            Assert.AreEqual(bracketChecker.HasMatchingBrackets, expected);
        }
        [TestMethod]
        public void TestString4()
        {
            var bracketChecker = new MatchingBracketChecker("");
            var expected = true;
            Assert.AreEqual(bracketChecker.HasMatchingBrackets, expected);
        }
        [TestMethod]
        public void TestString5()
        {
            var bracketChecker = new MatchingBracketChecker("{abc...xyz}");
            var expected = true;
            Assert.AreEqual(bracketChecker.HasMatchingBrackets, expected);
        }
    }
}
