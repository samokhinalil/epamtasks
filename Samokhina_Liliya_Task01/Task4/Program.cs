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

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int currentPositionX = n;
                int currentPositionY = 0;
                int k = n;

                Console.Clear();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - k + 1; j++)
                    {
                        var line = new string('*', j * 2 + 1);
                        Console.SetCursorPosition(currentPositionX, currentPositionY);
                        Console.WriteLine(line);
                        currentPositionX--;
                        currentPositionY++;
                    }
                    currentPositionX = n;
                    k--;
                }
            }
            else
            {
                Console.WriteLine("Data entered incorrectly");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
