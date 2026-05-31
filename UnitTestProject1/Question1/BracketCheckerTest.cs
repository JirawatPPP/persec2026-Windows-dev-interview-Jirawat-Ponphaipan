using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsDevInterview.Question1;
namespace Test.Question1
{
    [TestClass]
    public class BracketCheckerTest
    {
        [TestMethod]
        [DataRow("()", true)]
        [DataRow("([])", true)]
        [DataRow("([{}])", true)]
        [DataRow("([[{}]]])", false)]
        [DataRow(")", false)]
        [DataRow("()}", false)]
        [DataRow("(}]", false)]
        [DataRow("{", false)]
        public void IsBalanced_ShouldReturnExpectedResult(string input, bool expected)
        {
            bool result = BracketChecker.IsBalanced(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void IsBalanced_EmptyString_ShouldReturnTrue()
        {
            Assert.IsTrue(BracketChecker.IsBalanced(""));
        }
    }
}