using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sequence.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void ValidateTest_47_True()
        {
            bool expected = true;
            bool actual = Validation.Validate("47", out int result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateTest_Text_False()
        {
           bool expected = false;
           bool actual = Validation.Validate("Test", out int result);

                Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void ValidateTest_55_True()
        {
            bool expected = true;
            bool actual = Validation.Validate("55", out double result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPositiveTest_10_True()
        {
            bool expected = true;
            bool actual = Validation.IsPositive(10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPositiveTest_Negative_False()
        {
            bool expected = false;
            bool actual = Validation.IsPositive(-9);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsPositiveTest_Double_True()
        {
            bool expected = true;
            bool actual = Validation.IsPositive(678.5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPositiveTest_NegativeDouble_False()
        {
            bool expected = false;
            bool actual = Validation.IsPositive(-17.6);

            Assert.AreEqual(expected, actual);
        }
    }
}