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
        private int workExperience;
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
                if (value.Date.Year > DateTime.Now.Year - 90 && value.Date.Year <= DateTime.Now.Year)
                {
                    this.startWorkDate = value;
                }
                else
                {
                    throw new Exception("Date of start work is incorrect!");
                }
            }
        }

        public int WorkExperience
        {
            get
            {
                return this.workExperience = DateTime.Now.Year - this.startWorkDate.Year;
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
    }
}
