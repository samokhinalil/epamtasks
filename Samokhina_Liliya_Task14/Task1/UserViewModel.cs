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

        public string Awards
        {
            get
            {
                StringBuilder awardsView = new StringBuilder();
                if (User != null)
                {
                    foreach (var award in User.UserAwards)
                    {
                        awardsView.Append(award.Title + ";");
                    }
                }
                return awardsView.ToString();
            }
        }
    }
}
