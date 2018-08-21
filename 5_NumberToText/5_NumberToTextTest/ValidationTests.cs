using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5_NumberToText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_NumberToText.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void ValidateTest_MinValuePlusOne_True()
        {
            bool expected = true;
            bool actual = Validation.Validate("-9223372036854775807", out long result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidateTest_MaxValue_True()
        {
            bool expected = true;
            bool actual = Validation.Validate("9223372036854775807", out long result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidateTest_OutOfRange_False()
        {
            bool expected = false;
            bool actual = Validation.Validate("-10223372036854775807", out long result);

            Assert.AreEqual(expected, actual);
        }
    }
}