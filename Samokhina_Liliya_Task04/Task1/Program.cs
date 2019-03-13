using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static double СountAverageWordLength(string originString)
        {
            double averageWordLength = 0.0;
            string[] array = originString.Split(new char[] { ' ', ',', '.', '!', '?'},
                StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < array.Length; i++)
            {
                averageWordLength += array[i].Length;
            }

            averageWordLength /= array.Length;

            return averageWordLength;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            double result = СountAverageWordLength(Console.ReadLine());
            Console.WriteLine($"Average words length = {result}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
