using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Line : Shape
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }

        public Line(int x, int y, int x1, int y1):base(x, y)
        {
            X1 = x1;
            Y1 = y1;
        }

        public override void Draw()
        {
            Console.WriteLine($"Type: {this.GetType().Name}; {this.X}, {this.Y}, {this.X1}, {this.Y1}");
        }
    }
}
