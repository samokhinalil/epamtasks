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
            try
            {
                Employee employee = new Employee("surname", "name", "patr",
                    new DateTime(1998, 10, 27), new DateTime(2018, 01, 20), "programmer", 50000);
                
                Console.WriteLine(employee.ToString());
                employee.IncreaseSalary(10000);
                Console.WriteLine($"Salary after increasing = {employee.Salary}");
                Console.WriteLine($"Year salary= {employee.GetYearSalary()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
