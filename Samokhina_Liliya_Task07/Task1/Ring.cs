using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring : Round
    {
        private Round outerRound = new Round();

        public double OuterRadius
        {
            get
            {
                return outerRound.R;
            }

            set
            {
                if (value > this.R)
                {
                    outerRound.R = value;
                }
                else
                {
                    throw new Exception("Outer radius should be greater than inner!");
                }
            }
        }

        public override double Length
        {
            get
            {
                return base.Length + outerRound.Length;
            }
        }

        public override double Square
        {
            get
            {
                return outerRound.Square - base.Square;
            }
        }

        public Ring(int x, int y, double r, double outerRadius) : base(x, y, r)
        {
            this.outerRound = new Round(this.X, this.Y, OuterRadius = outerRadius);
        }

        public Ring(double outerRadius) : base()
        {
            this.outerRound = new Round(this.X, this.Y, OuterRadius = outerRadius);
        }

        public override void Draw()
        {
            Console.WriteLine($"Type: {this.GetType().Name}; {this.X}, {this.Y}, {this.R}, {this.OuterRadius}");
        }
    }
}
