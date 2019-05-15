using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndAwards.Entities;
using UsersAndAwards.Logic;

namespace UsersAndAwards
{
    public partial class UserForm : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Award> UserAwards { get; set; } = new List<Award>();
        public List<Award> Awards { get; set; } = new List<Award>();

        public UserForm(BLogic logic)
        {
            InitializeComponent();
            Text = "Добавить пользователя";

            Awards = logic.GetAllAwards();
            foreach (var award in Awards)
            {
                ctlAwards.Items.Add(award.Title);
            }
        }

        public UserForm(User user, BLogic logic)
        {
            InitializeComponent();
            Text = "Редактировать пользователя";

            tbFirstName.Text = user.FirstName;
            tbLastName.Text = user.LastName;
            ctlBirthDate.Text = user.BirthDate.ToShortDateString();
            UserAwards = user.UserAwards;
            Awards = logic.GetAllAwards();

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

        private void UserForm_Load(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                FirstName = tbFirstName.Text;
                LastName = tbLastName.Text;
                BirthDate = ctlBirthDate.Value.Date;

                UserAwards = new List<Award>();
                for (int i = 0; i < ctlAwards.Items.Count; i++)
                {
                    if (ctlAwards.GetItemChecked(i))
                    {
                        UserAwards.Add(Awards[i]);
                    }
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = tbFirstName.Text.Trim();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            string input = tbFirstName.Text.Trim();

            if (string.IsNullOrEmpty(input) || input.Length > 50)
            {
                errorProvider.SetError(tbFirstName, "First name can not be empty or more than 50 letters!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbFirstName, string.Empty);
            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            LastName = tbLastName.Text.Trim();
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            string input = tbLastName.Text.Trim();

            if (string.IsNullOrEmpty(input) || input.Length > 50)
            {
                errorProvider.SetError(tbLastName, "Last name can not be empty or more than 50 letters!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbLastName, string.Empty);
            }
        }

        private void ctlBirthDate_Validated(object sender, EventArgs e)
        {
            BirthDate = ctlBirthDate.Value.Date;
        }

        private void ctlBirthDate_Validating(object sender, CancelEventArgs e)
        {
            int dateConstraint = 150;
            DateTime date = ctlBirthDate.Value.Date;
            DateTime nowDate = DateTime.Now;

            if (date.Year > nowDate.Year - dateConstraint && date.Year <= nowDate.Year)
            {
                errorProvider.SetError(ctlBirthDate, string.Empty);
            }
            else
            {
                errorProvider.SetError(ctlBirthDate, "Incorrect birth date!");
                e.Cancel = true;
            }
        }
    }
}
