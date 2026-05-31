using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDevInterview.Question6;

namespace Tests.Question6
{
    [TestClass]
    public class TribonacciTest
    {
        // Normal Cases 
        [TestMethod]
        public void Tribonacci_NormalCase_135_5_Returns135917()
            {
            int[] signature = { 1, 3, 5 };
            int n = 5;
            int[] expected = { 1, 3, 5, 9, 17 };

            int[] actual = TribonacciSequence.Tribonacci(signature, n);

            CollectionAssert.AreEqual(expected, actual);
            }

        [TestMethod]
        public void Tribonacci_NormalCase_222_3_Returns222()
        {
            int[] signature = { 2, 2, 2 };
            int n = 3;
            int[] expected = { 2, 2, 2 };

            int[] actual = TribonacciSequence.Tribonacci(signature, n);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Tribonacci_NormalCase_101010_4_Returns10101030()
        {
            int[] signature = { 10, 10, 10 };
            int n = 4;
            int[] expected = { 10, 10, 10, 30 };

            int[] actual = TribonacciSequence.Tribonacci(signature, n);

            CollectionAssert.AreEqual(expected, actual);
        }

        // Alternative Cases 
        [TestMethod]
        public void Tribonacci_AlternativeCase_EmptySignature_5()
        {
            int[] signature = { };
            int n = 5;
            int[] expected = { 0, 0, 0, 0, 0 };

            int[] actual = TribonacciSequence.Tribonacci(signature, n);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Tribonacci_AlternativeCase_OneElement_4()
        {
            int[] signature = { 1 };
            int n = 4;
            int[] expected = { 0, 0, 1, 1 };

            int[] actual = TribonacciSequence.Tribonacci(signature, n);

            CollectionAssert.AreEqual(expected, actual);
        }

        // Exception Cases 
        [TestMethod]
        public void Tribonacci_ExceptionCase_NZero_ReturnsEmpty()
        {
            int[] signature = { 1, 3, 5 };
            int n = 0;
            int[] expected = { };

            int[] actual = TribonacciSequence.Tribonacci(signature, n);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Tribonacci_ExceptionCase_NullSignature_ThrowsException()
        {
            TribonacciSequence.Tribonacci(null, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Tribonacci_ExceptionCase_NegativeN_ThrowsException()
        {
            int[] signature = { 1, 3, 5 };

            TribonacciSequence.Tribonacci(signature, -1);
        }
    }
}