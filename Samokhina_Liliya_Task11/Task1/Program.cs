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
            var factorial = MathLibrary.MathLibrary.Factorial(5);
            var pow = MathLibrary.MathLibrary.Pow(2, 5);
            Console.WriteLine($"Factorial 5 = {factorial}");
            Console.WriteLine($"2^5 = {pow}");
            Console.ReadKey();
        }
    }
}
