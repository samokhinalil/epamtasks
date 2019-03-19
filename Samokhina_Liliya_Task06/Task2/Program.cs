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
                Ring ring = new Ring(0, 1, 2, 3);
                Console.WriteLine($"Ring square = {ring.Square}");
                Console.WriteLine($"Ring length = {ring.Perimeter}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
