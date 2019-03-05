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
            Console.WriteLine("Enter n =");

            string s = Console.ReadLine();
            int n = int.Parse(s);
            int currentPositionX = n;
            StringBuilder image = new StringBuilder("*");

            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(currentPositionX, i);
                Console.WriteLine(image);
                image.Append("**");
                currentPositionX--;
            }

            Console.ReadKey();
        }
    }
}
