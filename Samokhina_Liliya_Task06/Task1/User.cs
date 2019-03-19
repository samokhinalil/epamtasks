using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private string surname;
        private string name;
        private string patronymic;
        private DateTime birthDate;
        private int age;

        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                ValidateString(value, ref this.surname, "Surname");
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                ValidateString(value, ref this.name, "Name");
            }
        }

        public string Patronymic
        {
            get
            {
                return this.patronymic;
            }

            set
            {
                ValidateString(value, ref this.patronymic, "Patronymic");
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                if (value.Date.Year > DateTime.Now.Year - 120 && value.Date.Year < DateTime.Now.Year)
                {
                    this.birthDate = value;
                }
                else
                {
                    throw new Exception("Date of birth is incorrect!");
                }
            }
        }

        public int Age
        {
            get
            {
                this.age = DateTime.Now.Year - this.birthDate.Year;

                if (DateTime.Now.Month < this.birthDate.Month ||
                    (DateTime.Now.Month == this.birthDate.Month && DateTime.Now.Day < this.birthDate.Day))
                {
                    this.age--;
                }

                return this.age;
            }
        }

        public User(string surname, string name, string patronymic, DateTime birthDate)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            BirthDate = birthDate;
            this.age = Age;
        }

        override public string ToString()
        {
            return Surname + " " + Name + " " + Patronymic + " " + BirthDate + " " + Age;
        }
        
        public void ValidateString(string value, ref string field, string exceptionMessage)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (Regex.IsMatch(value, @"[a-zA-Z]+"))
                {
                    field = value;
                }
                else
                {
                    throw new Exception( $"{exceptionMessage} can only contains letters");
                }
            }
            else
            {
                throw new Exception($"{exceptionMessage} can not be empty!");
            }
        }
    }
}
