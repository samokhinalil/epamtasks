using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = InitializeArray(2, 3, 3);

            Console.WriteLine("Array:");
            ShowArray(array);

            ChangePositiveItemsToNull(array);

            Console.WriteLine("Changed array:");
            ShowArray(array);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static int[,,] InitializeArray(int size1, int size2, int size3)
        {
            var array = new int[size1, size2, size3];

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(-10, 10);
                    }
                }
            }
            return array;
        }

        private static void ShowArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0,4:D}", array[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        private static void ChangePositiveItemsToNull(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }
        }
    }
}
