using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle : Round
    {
        public string Color { get; set; }

        public Circle(string color) : base()
        {
            Color = color;
        }

        public Circle(int x, int y, double r, string color):base(x, y, r)
        {
            Color = color;
        }

        public override void Draw()
        {
            Console.WriteLine($"Type: {this.GetType().Name}; {this.X}, {this.Y}, {this.R}, {this.Color}");
        }
    }
}
