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

namespace UsersAndAwards
{
    public partial class AwardForm : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public string Title { get; set; }
        public string Description { get; set; }

        public AwardForm()
        {
            InitializeComponent();
            Text = "Добавить награду";
        }

        public AwardForm(Award award)
        {
            InitializeComponent();
            Text = "Редактировать награду";
            tbTitle.Text = award.Title;
            tbDescription.Text = award.Description;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Title = tbTitle.Text;
                Description = tbDescription.Text;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            string input = tbTitle.Text.Trim();

            if (string.IsNullOrEmpty(input) || input.Length > 50)
            {
                errorProvider.SetError(tbTitle, "Title can not be empty or more than 50 letters!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbTitle, string.Empty);
            }
        }

        private void tbTitle_Validated(object sender, EventArgs e)
        {
            Title = tbTitle.Text.Trim();
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            string input = tbDescription.Text.Trim();

            if (input.Length > 250)
            {
                errorProvider.SetError(tbDescription, "Description can not be more than 250 letters!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbDescription, string.Empty);
            }
        }

        private void tbDescription_Validated(object sender, EventArgs e)
        {
            Description = tbDescription.Text.Trim();
        }
    }
}
