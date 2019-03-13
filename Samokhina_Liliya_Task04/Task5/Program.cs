using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter HTML text:");
            string str = Console.ReadLine();
            str = Regex.Replace(str, @"<.*?>", "_");
            Console.WriteLine($"Result: {str}");
            Console.ReadKey();
        }
    }
}
