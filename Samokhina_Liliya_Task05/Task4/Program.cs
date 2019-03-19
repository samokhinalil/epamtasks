using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str1 = new MyString("abcd");
            MyString str2 = new MyString("bc");
            Console.WriteLine($"str1 = {str1.ToString()}, str2 = {str2.ToString()}");
            Console.WriteLine($"Is equals = {str1 == str2}");
            Console.WriteLine($"Is not equals = {str1 != str2}");
            Console.WriteLine($"Add str2 to str1: {str1 + str2}");
            Console.WriteLine($"Subtract str2 from str1: {str1 - str2}");
            Console.ReadKey();
        }
    }
}
