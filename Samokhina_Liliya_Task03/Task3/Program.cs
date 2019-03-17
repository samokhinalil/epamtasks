using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = InitializeArray(7);

            Console.WriteLine("Array:");
            ShowArray(array);

            Console.WriteLine($"Positive items sum = {FindPositiveItemsSum(array)}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static int[] InitializeArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
            return array;
        }

        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,4:D}", array[i]);
            }
            Console.WriteLine();
        }

        public static int FindPositiveItemsSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}
