using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6_HappyTickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_HappyTickets.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void ValidateTest_00013_True()
        {
            bool expected = true;
            bool actual = Validation.Validate("00013", out int result);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateTicketTest_757575_True()
        {
            bool expected = true;
            bool actual = Validation.IsTicket(757575);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidateTicketTest_8888888_False()
        {
            bool expected = false;
            bool actual = Validation.IsTicket(8888888);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ValidateMinMaxTest_67_77_True()
        {
            bool expected = true;
            bool actual = Validation.ValidateMinMax(67, 77);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidateMinMaxTest_83231_6_False()
        {
            bool expected = false;
            bool actual = Validation.ValidateMinMax(83231, 6);

            Assert.AreEqual(expected, actual);
        }
    }
}