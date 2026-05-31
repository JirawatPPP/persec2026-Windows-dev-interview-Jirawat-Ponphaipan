using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test.Question2
{
    [TestClass]
    public class ArrayTest
    {
        // Normal Cases 
        [TestMethod]
        public void SortStrings_NormalCase_SortByPrefixThenNumber()
        {
            string[] input = { "TH19", "SG20", "TH2" };
            string[] expected = { "SG20", "TH2", "TH19" };
            string[] actual = WindowsDevInterview.Question2.Array.SortStrings(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortStrings_NormalCase_SortWithSuffix()
        {
            string[] input = { "TH10", "TH3Netflix", "TH1", "TH7" };
            string[] expected = { "TH1", "TH3Netflix", "TH7", "TH10" };
            string[] actual = WindowsDevInterview.Question2.Array.SortStrings(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        // Alternative Cases 
        [TestMethod]
        public void SortStrings_AlternativeCase_SingleElement()
        {
            string[] input = { "TH1" };
            string[] expected = { "TH1" };
            string[] actual = WindowsDevInterview.Question2.Array.SortStrings(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortStrings_AlternativeCase_AlreadySorted()
        {
            string[] input = { "SG1", "TH1", "TH2", "TH10" };
            string[] expected = { "SG1", "TH1", "TH2", "TH10" };
            string[] actual = WindowsDevInterview.Question2.Array.SortStrings(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortStrings_AlternativeCase_SamePrefixSameNumber_SortBySuffix()
        {
            string[] input = { "TH1Netflix", "TH1Amazon", "TH1Grab" };
            string[] expected = { "TH1Amazon", "TH1Grab", "TH1Netflix" };
            string[] actual = WindowsDevInterview.Question2.Array.SortStrings(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        // Exception Cases 
        [TestMethod]
        public void SortStrings_ExceptionCase_NullInput_ReturnNull()
        {
            string[] actual = WindowsDevInterview.Question2.Array.SortStrings(null);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void SortStrings_ExceptionCase_EmptyArray_ReturnEmpty()
        {
            string[] input = { };
            string[] expected = { };
            string[] actual = WindowsDevInterview.Question2.Array.SortStrings(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}