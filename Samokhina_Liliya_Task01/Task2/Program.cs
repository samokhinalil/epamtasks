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
            Console.WriteLine("Enter n =");

            string s = Console.ReadLine();
            int n = int.Parse(s);
            StringBuilder image = new StringBuilder("*");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(image);
                image.Append("*");
            }

            Console.ReadKey();
        }
    }
}
