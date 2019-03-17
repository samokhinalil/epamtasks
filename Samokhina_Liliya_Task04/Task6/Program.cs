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
        public static int GetNumberNotation(string number)
        {
            if (Regex.IsMatch(number, @"^-?\d+(.?\d+)?e{1}-?\d+$"))
            {
                return 0;
            }
            else if (Regex.IsMatch(number, @"^-?\d+(.\d+)?$"))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int result = GetNumberNotation(Console.ReadLine());

            if (result == 0)
            {
                Console.WriteLine("The number is in scientific notation");
            }
            else if (result == 1)
            {
                Console.WriteLine("The number is in normal notation");
            }
            else
            {
                Console.WriteLine("It's not a number!");
            }

            Console.ReadKey();
        }
    }
}
