using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareNumbersFromFile("disposable_task_file.txt");
        }

        public static void SquareNumbersFromFile(string fileName)
        {
            string[] input = ReadFile(fileName);
            var result = SquareNumber(input);
            File.WriteAllLines(fileName, result);
        }

        private static string[] ReadFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllLines(fileName);
            }
            else
            {
                throw new Exception("File does not exist!");
            }
        }

        private static List<string> SquareNumber(string[] input)
        {
            List<string> numbers = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!string.IsNullOrEmpty(input[i]))
                {
                    numbers.Add(Math.Pow(double.Parse(input[i]), 2).ToString());
                }
            }
            return numbers;
        }
    }
}
