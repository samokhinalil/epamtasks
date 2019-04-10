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
            IEnumerable<int> enumerables = new int[] { 1, 2, 3, 4 };
            Task1.DynamicArray<int> array = new Task1.DynamicArray<int>(enumerables);
            array.Add(10);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
