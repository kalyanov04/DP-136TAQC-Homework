using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8_Fibonacci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Fibonacci.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void ValidateTest_55_True()
        {
            bool expected = true;
            bool actual = Validation.Validate("55", out int result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateTest_Text_False()
        {
           bool expected = false;
           bool actual = Validation.Validate("Hi", out int result);

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
        public void ValidateMinMaxTest_10_100_True()
        {
            bool expected = true;
            bool actual = Validation.ValidateMinMax(10,100);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidateMinMaxTest_55_1_False()
        {
            bool expected = false;
            bool actual = Validation.ValidateMinMax(55, 1);

            Assert.AreEqual(expected, actual);
        }
    }
}