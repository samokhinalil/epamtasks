using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Employee : User, IEquatable<Employee>
    {
        private DateTime startWorkDate;
        private string position;
        private double salary;
        private string passport;

        public string Passport
        {
            get
            {
                return passport;
            }

            set
            {
                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, @"\d{4}\s{1}\d{6}"))
                {
                    passport = value;
                }
                else
                {
                    throw new Exception("Incorrect passport");
                }
            }
        }

        public DateTime StartWorkDate
        {
            get
            {
                return startWorkDate;
            }
            set
            {
                ValidateDate(value, ref startWorkDate, 90, "Date of start work is incorrect!");
            }
        }

        public int WorkExperience
        {
            get
            {
                return CountYears(startWorkDate);
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                ValidateString(value, ref position, "Position");
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value > 0)
                {
                    salary = value;
                }
            }
        }

        public Employee(string surname, string name, string patronymic, DateTime birthDate,
            DateTime startWorkDate, string position, double salary, string passport) :
            base(surname, name, patronymic, birthDate)
        {
            StartWorkDate = startWorkDate;
            Position = position;
            Salary = salary;
            Passport = passport;
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

        public bool Equals(Employee other)
        {
            return (Passport.Equals(other.Passport));
        }
    }
}
