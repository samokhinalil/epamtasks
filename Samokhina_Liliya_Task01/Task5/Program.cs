using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 3; i < 1000; i += 3)
            {
                sum += i;
            }

            for (int i = 5; i < 1000; i += 5)
            {
                if (!(i % 3 == 0))
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of multiples of 3 or 5 :\n" + sum);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
