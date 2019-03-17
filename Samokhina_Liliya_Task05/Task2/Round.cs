using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        public int X { get; set; }
        public int Y { get; set; }
        private double r;

        public Round(int x, int y, double r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public Round(int x, int y):this(x, y, 1)
        {

        }

        public Round():this(0, 0, 1)
        {

        }

        public double R
        {
            get
            {
                return this.r;
            }

            set
            {
                if (value > 0)
                {
                    this.r = value;
                }
                else
                {
                    throw new Exception("Incorrect radius");
                }
            }
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * r;
            }
        }

        public double Square
        {
            get
            {
                return Math.PI * Math.Pow(r, 2);
            }
        }

    }
}
