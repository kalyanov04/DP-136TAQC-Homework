using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_NumberToText
{
    public class Converter
    {     
        public static string ConvertToHundreds(long number, bool male, string one, string two, string five)
        {
            string[] hundreds = {"", "сто ", "двести ", "триста ", "четыреста ",
                "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот "};

            string[] tens = {"", "десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ",
                "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто "};

            string[] totwenty = {"", "один ", "два ", "три ", "четыре ", "пять ", "шесть ",
                "семь ", "восемь ", "девять ", "десять ", "одиннадцать ",
                "двенадцать ", "тринадцать ", "четырнадцать ", "пятнадцать ",
                "шестнадцать ", "семнадцать ", "восемнадцать ", "девятнадцать "};

            long temp = number % 1000;

            if (temp == 0)
                return "";

            if (!male)
            {
                totwenty[1] = "одна ";
                totwenty[2] = "две ";
            }

            StringBuilder r = new StringBuilder(hundreds[temp / 100]);
      
            if (temp % 100 < 20)
            {
                r.Append(totwenty[temp % 100]);
            }
            else
            {
                r.Append(tens[temp % 100 / 10]);
                r.Append(totwenty[temp % 10]);
            }

            r.Append(Multi(temp, one, two, five));

            return r.ToString();
        }

        private static string Multi(long number, string one, string two, string five)
        {
            long temp;
            if (number % 100 > 20)
                temp = number % 10;
            else
                temp = number % 20;

            switch (temp)
            {
                case 1:
                    return one;
                case 2:
                case 3:
                case 4:
                    return two;
                default:
                    return five;
            }
        }
        public static string ConvertToString(long number)
        {
            long temp = number;

            StringBuilder sb = new StringBuilder();

            bool minus = false;
            if (temp < 0)
            {
                temp = -temp;
                minus = true;
            }
        
            if (0 == temp)
                sb.Append("ноль");

            if (temp % 1000 != 0)
                sb.Append(Converter.ConvertToHundreds(temp, true, "", "", ""));
            temp /= 1000;

            sb.Insert(0, Converter.ConvertToHundreds(temp, false, "тысяча ", "тысячи ", "тысяч "));
            temp /= 1000;

            sb.Insert(0, Converter.ConvertToHundreds(temp, true, "миллион ", "миллиона ", "миллионов "));
            temp /= 1000;

            sb.Insert(0, Converter.ConvertToHundreds(temp, true, "миллиард ", "миллиарда ", "миллиардов "));
            temp /= 1000;

            sb.Insert(0, Converter.ConvertToHundreds(temp, true, "триллион ", "триллиона ", "триллионов "));
            temp /= 1000;

            sb.Insert(0, Converter.ConvertToHundreds(temp, true, "квадриллион ", "квадриллиона ", "квадриллионов "));
            temp /= 1000;

            sb.Insert(0, Converter.ConvertToHundreds(temp, true, "квинтиллион ", "квинтиллиона ", "квинтиллионов "));

            if (minus)
                sb.Insert(0, "минус ");

            return sb.ToString();
        }
        public static long Input()
        {
            for (; ; )
            {
                Console.WriteLine("Enter number:");
                Console.Write("--> ");
                if (Validation.Validate(Console.ReadLine(), out long number))
                    return number;
            }
        }
    }
}
