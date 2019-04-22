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
    public partial class AwardForm : Form
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public AwardForm()
        {
            InitializeComponent();
        }

        public AwardForm(Award award)
        {
            InitializeComponent();
            tbTitle.Text = award.Title;
            tbDescription.Text = award.Description;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Title = tbTitle.Text;
            Description = tbDescription.Text;
        }
    }
}
