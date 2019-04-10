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

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                ValidateString(value, ref surname, "Surname");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                ValidateString(value, ref name, "Name");
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }

            set
            {
                ValidateString(value, ref patronymic, "Patronymic");
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                ValidateDate(value, ref birthDate, 120, "Date of birth is incorrect!");
            }
        }

        public int Age
        {
            get
            {
                return CountYears(birthDate);
            }
        }

        public User(string surname, string name, string patronymic, DateTime birthDate)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic} {BirthDate} {Age}";
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

        public void ValidateDate(DateTime value, ref DateTime field,
            int difference, string exceptionMessage)
        {
            DateTime date = DateTime.Now;
            if (value.Date.Year > date.Year - difference && value.Date.Year <= date.Year)
            {
                field = value;
            }
            else
            {
                throw new Exception(exceptionMessage);
            }
        }

        public int CountYears(DateTime field)
        {
            int calculatingField;
            DateTime date = DateTime.Now;
            calculatingField = date.Year - field.Year;

            if (date.Month < field.Month ||
                (date.Month == field.Month && date.Day < field.Day))
            {
                calculatingField--;
            }

            return calculatingField;
        }
    }
}
