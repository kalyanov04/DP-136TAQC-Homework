using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Matrix
{
    class Program
    {
        public static void Matrix(int size)
        {
            int[,] matrix = new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            int currentSide = size;

            int offset = 0;
            int currentNumber = 1;

            while (offset < size / 2.0)
            {
                for (int i = 0; i < currentSide; i++)
                {
                    matrix[offset, offset + i] = currentNumber;
                    currentNumber++;
                }


                for (int i = 0; i < currentSide - 2; i++)
                {
                    matrix[1 + offset + i, size - 1 - offset] = currentNumber;
                    currentNumber++;
                }

                if (size / 2 - offset > 0)
                {
                    for (int i = 0; i < currentSide; i++)
                    {
                        matrix[size - 1 - offset, size - 1 - i - offset] = currentNumber;
                        currentNumber++;
                    }
                }

                for (int i = 0; i < currentSide - 2; i++)
                {
                    matrix[size - 2 - offset - i, offset] = currentNumber;
                    currentNumber++;
                }

                offset++;
                currentSide -= 2;
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] < 10)
                    {
                        Console.Write(matrix[i, j]+"  ");
                    }
                    else
                        Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number");
            int size;
            Int32.TryParse(Console.ReadLine(), out size);

            Matrix(size);
        }
    }
}
