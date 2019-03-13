using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static void CompareCultureParams(string culture1, string culture2)
        {
            CultureInfo cult1 = new CultureInfo(culture1);
            CultureInfo cult2 = new CultureInfo(culture2);

            Console.WriteLine($"{cult1.Name}\t\t\t\t\t\t{cult2.Name}");

            Console.WriteLine("Date time pattern:");
            Console.WriteLine($"{cult1.DateTimeFormat.FullDateTimePattern}\t" +
                $"{cult2.DateTimeFormat.FullDateTimePattern}");

            Console.WriteLine("Number decimal separator:");
            Console.WriteLine($"{cult1.NumberFormat.NumberDecimalSeparator}\t\t\t\t\t\t" +
                $"{cult2.NumberFormat.NumberDecimalSeparator}");

            Console.WriteLine("Number group separator:");
            Console.WriteLine($"{cult1.NumberFormat.NumberGroupSeparator}\t\t\t\t\t\t" +
                $"{cult2.NumberFormat.NumberGroupSeparator}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            CompareCultureParams("ru", "en");
            CompareCultureParams("en", "");
            CompareCultureParams("ru", "");
            Console.ReadKey();
        }
    }
}
