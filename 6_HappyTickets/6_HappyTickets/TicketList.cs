using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_HappyTickets
{
    public class TicketList
    {
        ArrayList tickets;
        int minValue, maxValue;
        public int MinValue { get => minValue; set => minValue = value; }
        public int MaxValue { get => maxValue; set => maxValue = value; }
        public ArrayList Tickets { get => tickets; set => tickets = value; }

        public TicketList(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            Tickets = new ArrayList();
        }
        public void AddSimpleTickets()
        {
            for (int i = MinValue; i <= MaxValue; i++)
            {
                Ticket ticket = new Ticket(i);
                if (ticket.CheckHappySimple())
                    Tickets.Add(ticket);
            }
        }
        public void AddDifficultTickets()
        {
            for (int i = MinValue; i <= MaxValue; i++)
            {
                Ticket ticket = new Ticket(i);
                if(ticket.CheckHappyDifficult())
                    Tickets.Add(ticket);
            }
        }

        public static void CompareMethods(TicketList list1, TicketList list2)
        {
            if (list1.Tickets.Count > list2.Tickets.Count)
                Console.WriteLine("\nSimple method wins!");
            else if (list1.Tickets.Count < list2.Tickets.Count)
                Console.WriteLine("\nDifficult method wins!");
            else
                Console.WriteLine("Same amount!");
        }
    }
}
