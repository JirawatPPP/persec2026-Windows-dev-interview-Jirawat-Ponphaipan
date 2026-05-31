using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDevInterview.Question5;

namespace Test.Question5
{
    [TestClass]
    public class DigitSorterTest
    {
        // Normal Cases 
        [TestMethod]
        public void SortDescending_NormalCase_3008_Returns8300()
        {
            int input = 3008;
            int expected = 8300;
        
            int actual = DigitSorter.SortDescending(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortDescending_NormalCase_1989_Returns9981()
        {
            int input = 1989;
            int expected = 9981;

            int actual = DigitSorter.SortDescending(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortDescending_NormalCase_2679_Returns9762()
        {
            int input = 2679;
            int expected = 9762;

            int actual = DigitSorter.SortDescending(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortDescending_NormalCase_9163_Returns9631()
        {
            int input = 9163;
            int expected = 9631;

            int actual = DigitSorter.SortDescending(input);

            Assert.AreEqual(expected, actual);
        }

        // Alternative Cases 
        [TestMethod]
        public void SortDescending_AlternativeCase_SingleDigit_ReturnSame()
        {

            int input = 9;
            int expected = 9;

            int actual = DigitSorter.SortDescending(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortDescending_AlternativeCase_AllSameDigit_ReturnSame()
        {
            int input = 1111;
            int expected = 1111;

            int actual = DigitSorter.SortDescending(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortDescending_AlternativeCase_AlreadySorted_ReturnSame()
        {
            int input = 9631;
            int expected = 9631;

            int actual = DigitSorter.SortDescending(input);

            Assert.AreEqual(expected, actual);
        }

        // Exception Cases 
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortDescending_ExceptionCase_Zero_ThrowsException()
        {
            int input = 0;

            DigitSorter.SortDescending(input);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortDescending_ExceptionCase_Negative_ThrowsException()
        {
            
            int input = -1;

            DigitSorter.SortDescending(input);

        }
    }
}