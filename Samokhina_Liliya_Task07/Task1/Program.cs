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
            Shape[] shapes = new Shape[] { new Line(0, 0, 2, 3), new Round(), new Circle("red"),
                new Rectangle(0, 0, 4, 5), new Ring(1, 3, 2, 3) };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadKey();
        }
    }
}
