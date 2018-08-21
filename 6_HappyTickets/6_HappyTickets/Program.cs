using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6_HappyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("--Select menu--\n1.Compare methods\n2.Exit");
                ConsoleKeyInfo selection = Console.ReadKey();

                switch (selection.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        do
                        {
                            min = Ticket.Input("minimal");
                            max = Ticket.Input("maximal");
                        } while (!Validation.ValidateMinMax(min, max));
                        TicketList ticketListSimple = new TicketList(min, max);
                        ticketListSimple.AddSimpleTickets();
                        TicketList ticketListDifficult = new TicketList(min, max);
                        ticketListDifficult.AddDifficultTickets();
                        TicketList.CompareMethods(ticketListSimple, ticketListDifficult);
                        Console.WriteLine("Happy tickets with simple method: " + ticketListSimple.Tickets.Count);
                        Console.WriteLine("Happy ticket with difficult method: " + ticketListDifficult.Tickets.Count);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\bYou didn't select menu");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                }
            }
        }
    }
}
