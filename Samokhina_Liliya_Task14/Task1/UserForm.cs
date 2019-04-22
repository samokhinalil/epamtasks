using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class UserForm : Form
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Award> UserAwards { get; set; } = new List<Award>();
        public List<Award> Awards { get; set; } = new List<Award>();

        public UserForm(AwardStorage awardStorage)
        {
            InitializeComponent();
            Awards = awardStorage.GetAll();
            foreach (var award in Awards)
            {
                ctlAwards.Items.Add(award.Title);
            }
        }

        public UserForm(User user, AwardStorage awardStorage)
        {
            InitializeComponent();

            tbFirstName.Text = user.FirstName;
            tbLastName.Text = user.LastName;
            ctlBirthDate.Text = user.BirthDate.ToShortDateString();
            UserAwards = user.UserAwards;
            Awards = awardStorage.GetAll();

            int currentIndex = 0;

            foreach (var award in Awards)
            {
                ctlAwards.Items.Add(award.Title);
                if (UserAwards != null)
                {
                    foreach (var userAward in UserAwards)
                    {
                        if (award.ID == userAward.ID)
                        {
                            ctlAwards.SetItemChecked(currentIndex, true);
                        }
                    }
                    currentIndex++;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FirstName = tbFirstName.Text;
            LastName = tbLastName.Text;
            BirthDate = ctlBirthDate.Value.Date;

            for (int i = 0; i < ctlAwards.Items.Count; i++)
            {
                if (ctlAwards.GetItemChecked(i))
                {
                    UserAwards.Add(Awards[i]);
                }
            }
        }
    }
}
