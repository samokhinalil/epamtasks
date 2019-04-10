using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Office
    {
        private List<Person> office = new List<Person>();

        public void Add(Person person)
        {
            if(person != null)
            {
                Console.WriteLine($"{person.Name} came");
                foreach (var worker in office)
                {
                    person.Came += worker.Greet;
                }
                person.OnCame();
                office.Add(person);
                Console.WriteLine();
            }
        }

        public void Delete(Person person)
        {
            if(person != null && office.Contains(person))
            {
                Console.WriteLine($"{person.Name} left office");
                office.Remove(person);

                foreach (var worker in office)
                {
                    person.Leave += worker.Bye;
                    worker.Came -= person.Greet;
                }

                person.OnLeft();

                foreach (var worker in office)
                {
                    person.Leave -= worker.Bye;
                }

                Console.WriteLine();
            }
        }
    }
}
