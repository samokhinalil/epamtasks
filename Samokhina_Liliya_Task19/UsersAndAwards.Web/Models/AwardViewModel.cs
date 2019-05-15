using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsersAndAwards.Entities;

namespace UsersAndAwards.Web.Models
{
    public class AwardViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Checked { get; set; }

        public static AwardViewModel GetViewModel(Award award, List<Award> userAwards)
        {
            var model = new AwardViewModel();
            model.ID = award.ID;
            model.Title = award.Title;
            model.Description = award.Description;
            model.Checked = userAwards.Any(a => a.ID == award.ID);
            return model;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}