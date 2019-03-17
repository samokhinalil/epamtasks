using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        public static string DoubleCharactersInFirstLineFromSecondLine(string firstLine,
            string secondLine)
        {
            StringBuilder finalString = new StringBuilder();

            foreach (var character in firstLine)
            {
                finalString.Append(character);
                if (secondLine.Contains(character))
                {
                    finalString.Append(character);
                }
            }

            return finalString.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string firstLine = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            string secondLine = Console.ReadLine();
            string result = DoubleCharactersInFirstLineFromSecondLine(firstLine, secondLine);
            Console.WriteLine("String with doubled characters:");
            Console.WriteLine(result);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
