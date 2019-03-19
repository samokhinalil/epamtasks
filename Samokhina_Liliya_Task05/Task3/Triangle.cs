using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }

        public double Perimeter
        {
            get { return A + B + C; }
        }

        public double Square
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public Triangle(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new Exception("This triangle does not exist");
            }
        }
    }
}
