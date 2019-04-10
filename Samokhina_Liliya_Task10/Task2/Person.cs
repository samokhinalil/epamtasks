using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        public delegate void GreetMessage(Person person, DateTime time);
        public delegate void ByeMessage(Person person);

        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Greet(Person anotherPerson, DateTime time)
        {
            string greeting;
            var hour = time.Hour;
            if (hour > 8 && hour < 12)
            {
                greeting = "Good morning";
            }
            else if (hour >= 12 && hour < 17)
            {
                greeting = "Good afternoon";
            }
            else
            {
                greeting = "Good evening";
            }
            Console.WriteLine($"{greeting}, {anotherPerson.Name}!,- {Name} said.");
        }

        public void Bye(Person person)
        {
            Console.WriteLine($"Goodbye, {person.Name}!,- {Name} said.");
        }
        
        public event GreetMessage Came;
        public event ByeMessage Leave;

        public void OnCame()
        {
            Came?.Invoke(this, DateTime.Now);
        }

        public void OnLeft()
        {
            Leave?.Invoke(this);
        }
    }
}
