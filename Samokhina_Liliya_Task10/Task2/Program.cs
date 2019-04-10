using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task2.Person;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mary = new Person("Mary");
            Person kate = new Person("Kate");
            Person hugo = new Person("Hugo");
            Person john = new Person("John");

            Office office = new Office();
            office.Add(mary);
            office.Add(kate);
            office.Add(hugo);
            office.Add(john);

            office.Delete(mary);
            office.Delete(kate);
            office.Delete(hugo);
            office.Delete(john);

            Console.ReadKey();
        }
    }
}
