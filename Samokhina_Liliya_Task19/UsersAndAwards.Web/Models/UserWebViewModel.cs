using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsersAndAwards.Entities;

namespace UsersAndAwards.Web.Models
{
    public class UserWebViewModel
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age { get; set; }

        public string AwardsString
        {
            get
            {
                if (UserAwards != null)
                {
                    return string.Join("; ", UserAwards);
                }
                return string.Empty;
            }
        }

        public List<Award> UserAwards { get; set; }

        public List<AwardViewModel> AllAwards { get; set; }

        public User ToUser()
        {
            var user = new User(ID, FirstName, LastName, BirthDate, AllAwards
                    .Where(a => a.Checked == true)
                    .Select(a => new Award
                    {
                        ID = a.ID,
                        Title = a.Title,
                        Description = a.Description
                    }).ToList());
            return user;
        }

        public static UserWebViewModel GetViewModel(User user, List<Award> allAwards)
        {
            var userModel = new UserWebViewModel();
            if (user != null)
            {
                userModel.ID = user.ID;
                userModel.FirstName = user.FirstName;
                userModel.LastName = user.LastName;
                userModel.BirthDate = user.BirthDate;
                userModel.Age = user.Age;
                userModel.UserAwards = user.UserAwards;
            }
            var awards = new List<AwardViewModel>();
            foreach (var award in allAwards)
            {
                if (user != null)
                {
                    awards.Add(AwardViewModel.GetViewModel(award, user.UserAwards));
                }
                else
                {
                    awards.Add(AwardViewModel.GetViewModel(award));
                }
            }

            userModel.AllAwards = awards.ToList();
            return userModel;
        }
    }
}