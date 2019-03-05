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
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter width =");

            string width = Console.ReadLine();
            rectangle.setWidth(int.Parse(width));

            Console.WriteLine("Enter height =");

            string height = Console.ReadLine();
            rectangle.setHeight(int.Parse(height));

            try
            {
                int result = rectangle.getSquare();
                Console.WriteLine("Square = " + result);
            }
            catch
            {
                Console.WriteLine("Width or height can not be negative or null.\nPress any key to exit");
            }

            Console.ReadKey();
        }
    }
}
