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
            try
            {
                Round round = new Round(1, 1, 3);
                Console.WriteLine($"Round length = {round.Length}");
                Console.WriteLine($"Round square = {round.Square}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
