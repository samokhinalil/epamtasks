using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class UserViewModel
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
                return string.Join("; ", User.UserAwards);
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
