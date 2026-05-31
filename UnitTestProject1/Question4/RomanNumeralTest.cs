using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDevInterview.Question4;

namespace Test.Question4
{
    [TestClass]
    public class RomanNumeralTest
    {
        // ToRoman — Normal Cases 
        [TestMethod]
        public void ToRoman_NormalCase_1989_ReturnsMCMLXXXIX()
        {
            Assert.AreEqual("MCMLXXXIX", RomanNumeral.ToRoman(1989));
        }

        [TestMethod]
        public void ToRoman_NormalCase_2000_ReturnsMM()
        {
            Assert.AreEqual("MM", RomanNumeral.ToRoman(2000));
        }

        [TestMethod]
        public void ToRoman_NormalCase_68_ReturnsLXVIII()
        {
            Assert.AreEqual("LXVIII", RomanNumeral.ToRoman(68));
        }

        [TestMethod]
        public void ToRoman_NormalCase_109_ReturnsCIX()
        {
            Assert.AreEqual("CIX", RomanNumeral.ToRoman(109));
        }

        // ToRoman — Alternative Cases 
        [TestMethod]
        public void ToRoman_AlternativeCase_1_ReturnsI()
        {
            Assert.AreEqual("I", RomanNumeral.ToRoman(1));
        }

        [TestMethod]
        public void ToRoman_AlternativeCase_1800_ReturnsMDCCC()
        {
            Assert.AreEqual("MDCCC", RomanNumeral.ToRoman(1800));
        }

        // ToRoman — Exception Cases 
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ToRoman_ExceptionCase_Zero_ThrowsException()
        {
            RomanNumeral.ToRoman(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ToRoman_ExceptionCase_Over3999_ThrowsException()
        {
            RomanNumeral.ToRoman(4000);
        }

        // ToInt — Normal Cases 
        [TestMethod]
        public void ToInt_NormalCase_MCMLXXXIX_Returns1989()
        {
            Assert.AreEqual(1989, RomanNumeral.ToInt("MCMLXXXIX"));
        }

        [TestMethod]
        public void ToInt_NormalCase_MM_Returns2000()
        {
            Assert.AreEqual(2000, RomanNumeral.ToInt("MM"));
        }

        [TestMethod]
        public void ToInt_NormalCase_CIX_Returns109()
        {
            Assert.AreEqual(109, RomanNumeral.ToInt("CIX"));
        }

        // ToInt — Alternative Cases 
        [TestMethod]
        public void ToInt_AlternativeCase_I_Returns1()
        {
            Assert.AreEqual(1, RomanNumeral.ToInt("I"));
        }

        [TestMethod]
        public void ToInt_AlternativeCase_MDCCC_Returns1800()
        {
            Assert.AreEqual(1800, RomanNumeral.ToInt("MDCCC"));
        }

        // ToInt — Exception Cases 
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ToInt_ExceptionCase_Null_ThrowsException()
        {
            RomanNumeral.ToInt(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ToInt_ExceptionCase_Empty_ThrowsException()
        {
            RomanNumeral.ToInt("");
        }
    }
}
