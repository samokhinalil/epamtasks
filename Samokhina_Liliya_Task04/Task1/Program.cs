using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static double СountAverageWordLength(string originString)
        {
            var array = originString.ToCharArray();
            bool word = false;
            double sum = 0.0;
            int wordsNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(char.IsLetter(array[i]) && word == false)
                {
                    wordsNumber++;
                }

                if (char.IsLetter(array[i]))
                {
                    word = true;
                    sum++;
                }
                else
                {
                    word = false;
                }
            }

            return sum/wordsNumber;
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
