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
            
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    var line = new string('*', i + 1);
                    Console.WriteLine(line);
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
