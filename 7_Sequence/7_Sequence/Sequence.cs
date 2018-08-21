using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sequence
{
    public class Sequence
    {
        ArrayList elements;
        public ArrayList Elements { get => elements; set => elements = value; }

        public Sequence(int length, double number)
        {
            Elements = new ArrayList();
            this.createSequence(length, number);
        }
        private void createSequence(int length, double number)
        {
            int element = (int)Math.Ceiling((decimal)Math.Sqrt(number));
            while (length != 0)
            {
                length--;
                Elements.Add(element);
                element++;
            }
        }
        public override string ToString()
        {
            string output = "";
            foreach (var item in Elements)
            {
                output += item.ToString() + " ";
            }
            return output;
        }
    }
}
