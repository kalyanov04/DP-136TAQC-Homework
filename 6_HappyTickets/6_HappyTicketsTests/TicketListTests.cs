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
    public class TicketListTests
    {
        TicketList ticketList;
        int minValue;
        int maxValue;
        [TestInitialize()]
        public void TicketListTest()
        {
            int minValue = 0;
            int maxValue = 999999;
            ticketList = new TicketList(minValue, maxValue);
        }

        [TestMethod()]
        public void AddSimpleTicketsTest_AllTickets()
        {
            int expected = 55252;
            ticketList.AddSimpleTickets();
            int actual = ticketList.Tickets.Count;
            ticketList.Tickets.Clear();
            Assert.AreEqual(expected, actual);
        }
    }
}