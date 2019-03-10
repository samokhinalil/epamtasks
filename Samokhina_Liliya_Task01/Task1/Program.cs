using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width = ");

            if (int.TryParse(Console.ReadLine(), out int width) && width > 0)
            {
                Console.WriteLine("Enter height = ");

                if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
                {
                    Console.WriteLine($"Square = {width * height} ");
                }
                else
                {
                    Console.WriteLine("Height must be a number greater than zero!");
                }
            }
            else
            {
                Console.WriteLine("Width must be a number greater than zero!");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
