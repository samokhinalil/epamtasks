using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new List<TwoDPointWithHash>();
            for (int i = 0; i < 500000; i++)
            {
                points.Add(new TwoDPointWithHash(i, i + 1000));
                points.Add(new TwoDPointWithHash(i + 1000, i));
            }

            var hashList = new List<int>();
            foreach (var point in points)
            {
                hashList.Add(point.GetHashCode());
            }

            var distinctHashList = hashList.Distinct();
            Console.WriteLine($"Repeating hash code count = {points.Count - distinctHashList.Count()}");
            Console.ReadKey();
        }
    }
}
