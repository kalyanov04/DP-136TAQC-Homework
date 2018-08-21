using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Fibonacci
{
    public class Fibonacci
    {
        long min, max;
        int length;
        ArrayList listFibonacci;
        public Fibonacci(long min, long max)
        {
            this.min = min;
            this.max = max;
            ListFibonacci = new ArrayList();
            AddRange(0);
            AddRange(1);
            SetFibonacciNumber_RangeMode(0, 1);
        }

        public Fibonacci(int length)
        {
            this.length = length;
            ListFibonacci = new ArrayList();
            SetFibonacciNumber_LengthMode(0, 1);
        }

        public ArrayList ListFibonacci { get => listFibonacci; set => listFibonacci = value; }

        private void SetFibonacciNumber_RangeMode(long first, long second)
        {
            long sum = first + second;
            AddRange(sum);
            if(sum < max)
                SetFibonacciNumber_RangeMode(second, sum);
        }

        private void SetFibonacciNumber_LengthMode(long first, long second)
        {
            if (length == 1 && first == 0 && second==1)
            {
                ListFibonacci.Add(first);
                ListFibonacci.Add(second);
            }

            long sum = first + second;
            if (sum.ToString().Length == length)
            {
                ListFibonacci.Add(sum);
                SetFibonacciNumber_LengthMode(second, sum);
            }
            else if (sum.ToString().Length < length)
                SetFibonacciNumber_LengthMode(second, sum);            
        }
        private void AddRange(long number)
        {
            if (number >=min && number <=max)
            {
                ListFibonacci.Add(number);
            }
        }
        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < ListFibonacci.Count; i++)
                output+=ListFibonacci[i] + " ";

            return output;
        }
    }
}
