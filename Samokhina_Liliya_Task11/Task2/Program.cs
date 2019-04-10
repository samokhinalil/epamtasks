using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("a", "a", "a", new DateTime(1990, 10, 21),
                new DateTime(2016, 10, 21), "a", 15000, "1234 111111");
            Employee e2 = new Employee("a", "a", "a", new DateTime(1990, 10, 21),
                new DateTime(2016, 10, 21), "a", 15000, "1234 888888");
            Console.WriteLine($"Employee1 equals Employee2 : {e1.Equals(e2)}");
            Console.ReadKey();
        }
    }
}
