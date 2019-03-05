using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n =");

            string s = Console.ReadLine();
            int n = int.Parse(s);
            int k = n;
            int currentPositionX = n;
            int currentPositionY = 0;
            StringBuilder image = new StringBuilder("*");

            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - k + 1; j++)
                {
                    Console.SetCursorPosition(currentPositionX, currentPositionY);
                    Console.WriteLine(image);

                    image.Append("**");
                    currentPositionX--;
                    currentPositionY++;
                }

                image = new StringBuilder("*");
                currentPositionX = n;
                k--;
            }

            Console.ReadKey();
        }
    }
}
