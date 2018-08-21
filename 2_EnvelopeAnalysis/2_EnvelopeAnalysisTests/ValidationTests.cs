using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2_EnvelopeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_EnvelopeAnalysis.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void IsNumberTest_10_6_True()
        {
            string data = "10,6";
            bool expected = true;
            bool actual = Validation.IsNumber(data, out double result);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsNumberTest_SomeText_False()
        {
            string data = "SomeText";
            bool expected = false;
            bool actual = Validation.IsNumber(data, out double result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsPositiveTest_16_2_True()
        {
            double data = 16.2;
            bool expected = true;
            bool actual = Validation.IsPositive(data);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsPositiveTest_Minus3_3_False()
        {
            double data = -3.3;
            bool expected = false;
            bool actual = Validation.IsPositive(data);

            Assert.AreEqual(expected, actual);
        }
    }
}