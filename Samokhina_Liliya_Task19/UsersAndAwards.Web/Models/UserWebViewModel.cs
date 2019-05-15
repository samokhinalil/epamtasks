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
                if (AvailableAwards != null)
                {
                    return string.Join("; ", AvailableAwards);
                }
                return string.Empty;
            }
        }

        public List<Award> Awards { get; set; }

        public List<AwardViewModel> AvailableAwards { get; set; }

        public User ToUser()
        {
            var user = new User(ID, FirstName, LastName, BirthDate, AvailableAwards
                    .Where(a => a.Checked == true)
                    .Select(a => new Award
                    {
                        ID = a.ID,
                        Title = a.Title,
                        Description = a.Description
                    }).ToList());
            return user;
        }

        public static UserWebViewModel GetViewModel(User user, List<Award> availableAwards, List<Award> allAwards)
        {
            var userModel = new UserWebViewModel();
            userModel.ID = user.ID;
            userModel.FirstName = user.FirstName;
            userModel.LastName = user.LastName;
            userModel.BirthDate = user.BirthDate;
            userModel.Age = user.Age;
            userModel.Awards = allAwards;
            var awards = new List<AwardViewModel>();
            foreach (var award in availableAwards)
            {
                awards.Add(AwardViewModel.GetViewModel(award, user.UserAwards));
            }

            userModel.AvailableAwards = awards.ToList();
            return userModel;
        }
    }
}