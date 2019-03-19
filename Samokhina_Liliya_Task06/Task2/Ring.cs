using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring
    {
        private Round innerRound;
        private Round outerRound;

        public int X
        {
            get
            {
                return innerRound.X;
            }

            set
            {
                innerRound.X = value;
            }
        }

        public int Y
        {
            get
            {
                return innerRound.Y;
            }

            set
            {
                innerRound.Y = value;
            }
        }

        public double InnerRadius
        {
            get
            {
                return innerRound.R;
            }

            set
            {
                if (value < OuterRadius)
                {
                    innerRound.R = value;
                }
                else
                {
                    throw new Exception("Inner radius must be less than outer");
                }
            }
        }

        public double OuterRadius
        {
            get
            {
                return outerRound.R;
            }

            set
            {
                outerRound.R = value;
            }
        }

        public double Square
        {
            get
            {
                return outerRound.Square - innerRound.Square;
            }
        }

        public double Perimeter
        {
            get
            {
                return outerRound.Length + innerRound.Length;
            }
        }

        public Ring(int x, int y, int innerR, int outerR)
        {
            innerRound = new Round(x, y, innerR);
            outerRound = new Round(x, y, outerR);
            InnerRadius = innerR;
            OuterRadius = outerR;
        }
    }
}
