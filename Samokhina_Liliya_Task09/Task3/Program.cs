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
            string input = "cat,. ,   dog=-+ milk Cat? cat, milk eat";
            var dictionary = WordCounter.CountWords(input);
            Console.WriteLine("Words number:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
