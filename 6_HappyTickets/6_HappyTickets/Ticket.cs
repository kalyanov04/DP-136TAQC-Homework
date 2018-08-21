using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_HappyTickets
{
    public class Ticket
    {
        int number;
        public int Number { get => number; set => number = value; }

        public Ticket(int number)
        {
            Number = number;
        }

        public bool CheckHappySimple()
        {
            int sumFirstThree = 0;
            int sumLastThree = 0;
            int tempNumber = Number;

            for (int i = 0; i < 3; i++)
            {
                sumLastThree += tempNumber % 10;
                tempNumber /= 10;
            }

            for (int i = 0; i < 3; i++)
            {
                sumFirstThree += tempNumber % 10;
                tempNumber /= 10;
            }

            if (sumFirstThree == sumLastThree)
                return true;
            else
                return false;
        }

        public bool CheckHappyDifficult()
        {
            int sumEven = 0;
            int sumNotEven = 0;
            int tempNumber = Number;

            for (int i = 0; i < 6; i++)
            {
                int digit = tempNumber % 10;
                if (digit % 2 == 0)
                    sumEven += digit;
                else
                    sumNotEven += digit;

                tempNumber /= 10;
            }

            if (sumEven == sumNotEven)
                return true;
            else
                return false;
        }
        public static int Input(string parameter)
        {
            for (; ; )
            {
                Console.WriteLine("Enter {0} ticket number", parameter);
                Console.Write("--> ");
                if (Validation.Validate(Console.ReadLine(), out int number) && Validation.IsTicket(number))
                    return number;
            }
        }
    }
}
