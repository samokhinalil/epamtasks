using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer1 = new Stopwatch();
            Stopwatch timer2 = new Stopwatch();
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;

            timer1.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            timer1.Stop();
            Console.WriteLine($"String execution time: {timer1.Elapsed}");

            timer2.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            timer2.Stop();
            Console.WriteLine($"StringBuilder execution time: {timer2.Elapsed}");

            Console.ReadKey();
        }
    }
}
