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
    public partial class MainForm : System.Windows.Forms.Form
    {
        private enum SortMode { Asceding, Desceding };
        private SortMode _sortMode = SortMode.Asceding;
        BLogic logic = new BLogic();

        public MainForm()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
            dgvAwards.AutoGenerateColumns = false;

            UpdateDgvUsers();
            UpdateDgvAwards();
        }

        private void UpdateDgvUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = logic.GetAllUsers().Select(u => new UserViewModel(u)).ToList();
        }

        private void UpdateDgvAwards()
        {
            dgvAwards.DataSource = null;
            dgvAwards.DataSource = logic.GetAllAwards();
        }

        private void AddUser()
        {
            UserForm userForm = new UserForm(logic);
            userForm.ShowDialog();

            if (userForm.DialogResult == DialogResult.OK)
            {
                logic.AddUser(new User(userForm.FirstName, userForm.LastName, userForm.BirthDate, userForm.UserAwards));
                UpdateDgvUsers();
            }
        }

        private void EditUser()
        {
            UserViewModel userView = (UserViewModel)dgvUsers.CurrentRow.DataBoundItem;
            User user = userView.User;
            UserForm userForm = new UserForm(user, logic);
            userForm.ShowDialog();
            if (userForm.DialogResult == DialogResult.OK)
            {
                user.FirstName = userForm.FirstName;
                user.LastName = userForm.LastName;
                user.BirthDate = userForm.BirthDate;
                user.UserAwards = userForm.UserAwards;
                logic.EditUser(user);
                UpdateDgvUsers();
            }
        }

        private void DeleteUser()
        {
            UserViewModel userView = (UserViewModel)dgvUsers.CurrentRow.DataBoundItem;
            User user = userView.User;
            if (MessageBox.Show($"Удалить пользователя {user.FirstName}?", "Удаление пользователя",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                logic.RemoveUser(user);
                UpdateDgvUsers();
            }
        }

        private void AddAward()
        {
            AwardForm awardForm = new AwardForm();
            awardForm.ShowDialog();
            if (awardForm.DialogResult == DialogResult.OK)
            {
                logic.AddAward(new Award(awardForm.Title, awardForm.Description));
                UpdateDgvAwards();
            }
        }

        private void EditAward()
        {
            Award award = (Award)dgvAwards.CurrentRow.DataBoundItem;
            AwardForm awardForm = new AwardForm(award);
            awardForm.ShowDialog();
            if (awardForm.DialogResult == DialogResult.OK)
            {
                award.Title = awardForm.Title;
                award.Description = awardForm.Description;
                logic.EditAward(award);
                UpdateDgvAwards();
            }
        }

        private void DeleteAward()
        {
            Award award = (Award)dgvAwards.CurrentRow.DataBoundItem;
            if (MessageBox.Show($"Удалить награду {award.Title}?", "Удаление награды",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (var user in logic.GetAllUsers())
                {
                    if (user.UserAwards.Contains(award))
                    {
                        user.UserAwards.Remove(award);
                    }
                }
                logic.RemoveAward(award);
                UpdateDgvAwards();
            }
        }

        private void ctlAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void ctlEditUser_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void ctlDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void ctlAddAward_Click(object sender, EventArgs e)
        {
            AddAward();
        }

        private void ctlEditAward_Click(object sender, EventArgs e)
        {
            EditAward();
        }

        private void ctlDeleteAward_Click(object sender, EventArgs e)
        {
            DeleteAward();
        }

        private void SortUsersByFirstNameAsc()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = logic.GetAllUsers().Select(u => new UserViewModel(u)).OrderBy(u => u.FirstName).ToList();
        }

        private void SortUsersByFirstNameDesc()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = logic.GetAllUsers().Select(u => new UserViewModel(u)).OrderByDescending(u => u.FirstName).ToList();
        }

        private void SortUsersByLastNameAsc()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = logic.GetAllUsers().Select(u => new UserViewModel(u)).OrderBy(u => u.LastName).ToList();
        }

        private void SortUsersByLastNameDesc()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = logic.GetAllUsers().Select(u => new UserViewModel(u)).OrderByDescending(u => u.LastName).ToList();
        }

        private void SortUsersByAgeAsc()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = logic.GetAllUsers().Select(u => new UserViewModel(u)).OrderBy(u => u.Age).ToList();
        }

        private void SortUsersByAgeDesc()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = logic.GetAllUsers().Select(u => new UserViewModel(u)).OrderByDescending(u => u.Age).ToList();
        }

        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    if (_sortMode == SortMode.Asceding)
                    {
                        SortUsersByFirstNameAsc();
                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        SortUsersByFirstNameDesc();
                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 1:
                    if (_sortMode == SortMode.Asceding)
                    {
                        SortUsersByLastNameAsc();
                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        SortUsersByLastNameDesc();
                        _sortMode = SortMode.Asceding;
                    }
                    break;
                case 3:
                    if (_sortMode == SortMode.Asceding)
                    {
                        SortUsersByAgeAsc();
                        _sortMode = SortMode.Desceding;
                    }
                    else
                    {
                        SortUsersByAgeDesc();
                        _sortMode = SortMode.Asceding;
                    }
                    break;
                default:
                    break;
            }
        }

        private void ctlClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
