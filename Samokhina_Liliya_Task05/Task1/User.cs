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

        public User(string surname, string name, string patronymic, ref DateTime birthDate)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            BirthDate = birthDate;
            this.age = Age;
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                ValidateName(value, ref this.surname);
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
                ValidateName(value, ref this.name);
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
                ValidateName(value, ref this.patronymic);
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

        override public string ToString()
        {
            return Surname + " " + Name + " " + Patronymic + " " + BirthDate + " " + Age;
        }

        private void ValidateName(string value, ref string namePart)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (Regex.IsMatch(value, @"[a-zA-Z]+"))
                {
                    namePart = value;
                }
                else
                {
                    throw new Exception("Name part can only contains letters");
                }
            }
            else
            {
                throw new Exception("Name part can not be empty!");
            }
        }

    }
}
