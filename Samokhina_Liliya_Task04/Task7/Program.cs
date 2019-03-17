using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        public static int CountTimeNumber(string input)
        {
            //var match = Regex.Matches(input, @"(^|\s)([01]?[0-9]|2[0-3]):[0-5][0-9]($|\s)");
            //return match.Count;

            int count = 0;
            var words = input.Split(' ', ',', '.');
            foreach (var item in words)
            {
                if (Regex.IsMatch(item, @"^([01]?[0-9]|2[0-3]):[0-5][0-9]"))
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text with time:");
            var str = Console.ReadLine();
            Console.WriteLine($"Time in text occurs = {CountTimeNumber(str)} times");
            Console.ReadKey();
        }
    }
}
