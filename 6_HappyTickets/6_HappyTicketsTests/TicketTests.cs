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
    public class TicketTests
    {
        Ticket ticket1, ticket2, ticket3, ticket4;
        [TestInitialize()]
        public void TicketTest()
        {
            ticket1 = new Ticket(121121);
            ticket2 = new Ticket(007831);
            ticket3 = new Ticket(999999);
            ticket4 = new Ticket(713588);
        }

        [TestMethod()]
        public void CheckHappySimpleTest_ObjTicket1_True()
        {
            bool expected = true;
            bool actual = ticket1.CheckHappySimple();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckHappyDifficultTest_ObjTicket1_True()
        {
            bool expected = true;
            bool actual = ticket1.CheckHappyDifficult();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckHappySimpleTest_ObjTicket2_False()
        {
            bool expected = false;
            bool actual = ticket2.CheckHappySimple();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckHappyDifficultTest_ObjTicket2_False()
        {
            bool expected = false;
            bool actual = ticket2.CheckHappyDifficult();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckHappySimpleTest_ObjTicket3_True()
        {
            bool expected = true;
            bool actual = ticket3.CheckHappySimple();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckHappyDifficultTest_ObjTicket3_False()
        {
            bool expected = false;
            bool actual = ticket3.CheckHappyDifficult();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckHappySimpleTest_ObjTicket4_True()
        {
            bool expected = false;
            bool actual = ticket4.CheckHappySimple();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckHappyDifficultTest_ObjTicket4_True()
        {
            bool expected = true;
            bool actual = ticket4.CheckHappyDifficult();

            Assert.AreEqual(expected, actual);
        }
    }
}