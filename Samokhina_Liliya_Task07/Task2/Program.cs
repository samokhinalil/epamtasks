using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeries arithmeticalProgression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Arithmetical progression:");
            PrintSeries(arithmeticalProgression);

            ISeries list = new List(new double[] { 5, 8, 6, 3, 1 });
            Console.WriteLine("List:");
            PrintSeries(list);

            ISeries geometricProgression = new GeometricProgression(2, 2);
            Console.WriteLine("Geometric progression:");
            PrintSeries(geometricProgression);

            Console.ReadKey();
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
