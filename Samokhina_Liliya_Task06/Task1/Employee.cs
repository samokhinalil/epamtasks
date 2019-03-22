using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Employee : User
    {
        private DateTime startWorkDate;
        private string position;
        private double salary;

        public DateTime StartWorkDate
        {
            get
            {
                return this.startWorkDate;
            }
            set
            {
                ValidateDate(value, ref this.startWorkDate, 90, "Date of start work is incorrect!");
            }
        }

        public int WorkExperience
        {
            get
            {
                return CountYears(this.startWorkDate);
            }
        }

        public string Position
        {
            get
            {
                return this.position;
            }

            set
            {
                ValidateString(value, ref this.position, "Position");
            }
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value > 0)
                {
                    this.salary = value;
                }
            }
        }

        public Employee(string surname, string name, string patronymic, DateTime birthDate,
            DateTime startWorkDate, string position, double salary) :
            base(surname, name, patronymic, birthDate)
        {
            StartWorkDate = startWorkDate;
            Position = position;
            Salary = salary;
        }

        public double GetYearSalary()
        {
            return Salary * 12;
        }

        public double IncreaseSalary(double increment)
        {
            return Salary += increment;
        }

        public override string ToString()
        {
            return $"Name: {Surname} {Name} {Patronymic}" +
                $" Birth date: {BirthDate}" +
                $" Age: {Age}" +
                $"\nWork experience: {WorkExperience}" +
                $" Position: {Position}" +
                $" Salary: {Salary}";
        }
    }
}
