using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        private const int dateConstraint = 150;
        private static int id = 1;

        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;

        public List<Award> UserAwards { get; set; }

        public int ID { get; private set; }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                ValidateString(value, ref _firstName, "First name");
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                ValidateString(value, ref _lastName, "Last name");
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }

            set
            {
                DateTime date = DateTime.Now;
                if (value.Date.Year > date.Year - dateConstraint && value.Date.Year <= date.Year)
                {
                    _birthDate = value;
                }
                else
                {
                    throw new Exception("Incorrect birth date!");
                }
            }
        }

        public int Age
        {
            get
            {
                if (_birthDate != null)
                {
                    DateTime date = DateTime.Now;
                    int age = date.Year - _birthDate.Year;

                    if (date.Month < _birthDate.Month ||
                        (date.Month == _birthDate.Month && date.Day < _birthDate.Day))
                    {
                        age--;
                    }
                    return age;
                }
                else
                {
                    return 0;
                }
            }
        }

        public User(string firstName, string lastName, DateTime birthDate, List<Award> userAwards)
        {
            ID = id;
            id++;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            UserAwards = userAwards;
        }

        public void ValidateString(string value, ref string field, string exceptionMessage)
        {
            if (!string.IsNullOrEmpty(value))
            {
                field = value;
                //if (Regex.IsMatch(value, @"[a-zA-Z]+"))
                //{
                //    field = value;
                //}
                //else
                //{
                //    throw new Exception($"{exceptionMessage} can only contains letters");
                //}
            }
            else
            {
                throw new Exception($"{exceptionMessage} can not be empty!");
            }
        }
    }
}
