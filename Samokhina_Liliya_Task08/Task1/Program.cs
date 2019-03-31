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
            DynamicArray<int> dynamic = new DynamicArray<int>(1);
            for (int i = 1; i < 5; i++)
            {
                dynamic.Add(i);
            }

            dynamic.AddRange(new int[] { 6, 7, 8 });
            dynamic.Remove(6);
            dynamic.Insert(4, 10);
            Console.WriteLine($"Length = {dynamic.Length}, Capacity = {dynamic.Capacity}");
            Console.ReadKey();
        }
    }
}
