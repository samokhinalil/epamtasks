using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round : Shape
    {
        private double r;

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
                    throw new Exception("Radius should be greater than zero");
                }
            }
        }

        public virtual double Length
        {
            get
            {
                return 2 * Math.PI * r;
            }
        }

        public virtual double Square
        {
            get
            {
                return Math.PI * Math.Pow(r, 2);
            }
        }

        public Round(int x, int y, double r) : base(x, y)
        {
            X = x;
            Y = y;
            R = r;
        }

        public Round(int x, int y) : this(x, y, 1)
        {

        }

        public Round() : this(0, 0, 1)
        {

        }

        public override void Draw()
        {
            Console.WriteLine($"Type: {this.GetType().Name}; {this.X}, {this.Y}, {this.R}");
        }
    }
}
