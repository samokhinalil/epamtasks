using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        private static void GetNumberNotation(string number)
        {
            if (Regex.IsMatch(number, @"^-?\d+(.?\d+)?e{1}-?\d+$"))
            {
                Console.WriteLine("The number is in scientific notation");
            }
            else if (Regex.IsMatch(number, @"^-?\d+(.\d+)?$"))
            {
                Console.WriteLine("The number is in normal notation");
            }
            else
            {
                Console.WriteLine("It's not a number!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            GetNumberNotation(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
