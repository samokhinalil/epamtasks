﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards.Entities
{
    public class UserViewModel
    {
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }

        public string Awards
        {
            get
            {
                if(User.UserAwards != null)
                {
                    return string.Join("; ", User.UserAwards);
                }
                return string.Empty;
            }
        }

        public UserViewModel(User user)
        {
            User = user;
            FirstName = user.FirstName;
            LastName = user.LastName;
            BirthDate = user.BirthDate;
            Age = user.Age;
        }
    }
}
