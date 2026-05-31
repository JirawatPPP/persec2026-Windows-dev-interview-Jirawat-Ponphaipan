using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDevInterview.Question3;

namespace Test.Question3
{
    [TestClass]
    public class AutoCompleteTest
    {
        // Normal Cases 
        [TestMethod]
        public void Autocomplete_NormalCase_ReturnCorrectOrder()
        {
            string[] items = { "Mother", "Think", "Worthy", "Apple", "Android" };
            string[] expected = { "Think", "Mother" };
            string[] actual = AutoComplete.Autocomplete("th", items, 2);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Autocomplete_NormalCase_MaxResultLargerThanMatches()
        {
            string[] items = { "Mother", "Think", "Worthy" };
            string[] expected = { "Think", "Mother", "Worthy" };
            string[] actual = AutoComplete.Autocomplete("th", items, 10);
            CollectionAssert.AreEqual(expected, actual);
        }

        // Alternative Cases 
        [TestMethod]
        public void Autocomplete_AlternativeCase_IgnoreCase()
        {
            string[] items = { "Mother", "Think", "Worthy" };
            string[] expected = { "Think", "Mother", "Worthy" };
            string[] actual = AutoComplete.Autocomplete("TH", items, 10);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Autocomplete_AlternativeCase_NoMatch_ReturnEmpty()
        {
            string[] items = { "Apple", "Android" };
            string[] actual = AutoComplete.Autocomplete("th", items, 5);
            Assert.AreEqual(0, actual.Length);
        }

        // Exception Cases 
        [TestMethod]
        public void Autocomplete_ExceptionCase_NullItems_ReturnEmpty()
        {
            string[] actual = AutoComplete.Autocomplete("th", null, 5);
            Assert.AreEqual(0, actual.Length);
        }

        [TestMethod]
        public void Autocomplete_ExceptionCase_EmptySearch_ReturnEmpty()
        {
            string[] items = { "Mother", "Think" };
            string[] actual = AutoComplete.Autocomplete("", items, 5);
            Assert.AreEqual(0, actual.Length);
        }

        [TestMethod]
        public void Autocomplete_ExceptionCase_MaxResultZero_ReturnEmpty()
        {
            string[] items = { "Mother", "Think" };
            string[] actual = AutoComplete.Autocomplete("th", items, 0);
            Assert.AreEqual(0, actual.Length);
        }
    }
}
