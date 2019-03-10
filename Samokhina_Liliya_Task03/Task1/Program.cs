using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = InitializeArray(7);

            Console.WriteLine("Array:");
            ShowArray(array);

            Console.WriteLine($"Max item = {FindMax(array)}");
            Console.WriteLine($"Min item = {FindMin(array)}");

            Sort(array);

            Console.WriteLine("Sorted array:");
            ShowArray(array);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static int[] InitializeArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            return array;
        }

        private static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,4:D}", array[i]);
            }
            Console.WriteLine();
        }
        
        private static int FindMax(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        private static int FindMin(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        private static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
