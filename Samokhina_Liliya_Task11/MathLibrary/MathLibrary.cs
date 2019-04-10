using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathLibrary
    {
        public static int Factorial(int n)
        {
            if (n >= 0)
            {
                var result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            else
            {
                throw new Exception("Number must be > 0");
            }
        }

        public static int Pow(int number, int pow)
        {
            var result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
