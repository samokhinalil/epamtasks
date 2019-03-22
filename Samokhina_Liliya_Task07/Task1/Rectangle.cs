using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if(value > 0)
                {
                    this.width = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
            }
        }

        public Rectangle(int x, int y, int width, int height):base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Type: {this.GetType().Name}; {this.X}, {this.Y}, " +
                $"{this.Width}, {this.Height}");
        }
    }
}
