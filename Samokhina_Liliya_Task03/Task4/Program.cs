using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = InitializeArray(3, 3);

            Console.WriteLine("Array:");
            ShowArray(array);

            Console.WriteLine($"Sum of even items = {FindEvenItemsSum(array)}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static int[,] InitializeArray(int size1, int size2)
        {
            var array = new int[size1, size2];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 5);
                }
            }

            return array;
        }

        private static void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,4:D}", array[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static int FindEvenItemsSum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
