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
            string[] array = { "nsd", "a", "vb", "ab", "asd" };

            Console.WriteLine("String array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            StringSorter.Sort(array, SortByAscLength);

            Console.WriteLine("After asc sort");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            StringSorter.Sort(array, SortByDescLength);

            Console.WriteLine("After desc sort");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static bool SortByAscLength(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return true;
            }
            else if (str1.Length == str2.Length)
            {
                return (str1.CompareTo(str2) > 0);
            }
            else
            {
                return false;
            }
        }

        public static bool SortByDescLength(string str1, string str2)
        {
            return !SortByAscLength(str1, str2);
        }
    }
}
