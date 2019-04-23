﻿using System;
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
    public partial class MainForm : System.Windows.Forms.Form
    {
        private enum SortMode { Asceding, Desceding };
        private SortMode _sortMode = SortMode.Asceding;

        private UserStorage _userStorage = new UserStorage();
        private AwardStorage _awardStorage = new AwardStorage();
        
        public MainForm()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
            dgvAwards.AutoGenerateColumns = false;
            
            Award award1 = new Award("award1", "award1");
            Award award2 = new Award("award2", "award2");
            
            _awardStorage.Add(award1);
            _awardStorage.Add(award2);

            User user1 = new User("user1 firstName", "user1 lastName", new DateTime(1998, 10, 27), new List<Award> { award1, award2 });
            User user2 = new User("user2 firstName", "user2 lastName", new DateTime(2000, 10, 25), new List<Award> { award1 });
            User user3 = new User("user3 firstName", "user3 lastName", new DateTime(1995, 10, 23), new List<Award> { award2 });
            
            _userStorage.Add(user1);
            _userStorage.Add(user2);
            _userStorage.Add(user3);
            
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _userStorage.GetAll().Select(u => new UserViewModel(u)).ToList();

            dgvAwards.DataSource = null;
            dgvAwards.DataSource = _awardStorage.GetAll();
        }

        private void ctlAddUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(_awardStorage) { Text = "Добавить пользователя" };
            userForm.ShowDialog();
            
            if (userForm.DialogResult == DialogResult.OK)
            {
                _userStorage.Add(new User(userForm.FirstName, userForm.LastName, userForm.BirthDate, userForm.UserAwards));
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = _userStorage.GetAll();
            }
        }
        
        private void ctlEditUser_Click(object sender, EventArgs e)
        {
            UserViewModel userView = (UserViewModel)dgvUsers.CurrentRow.DataBoundItem;
            User user = userView.User;
            UserForm userForm = new UserForm(user, _awardStorage) { Text = "Редактировать пользователя" };
            userForm.ShowDialog();
            if (userForm.DialogResult == DialogResult.OK)
            {
                user.FirstName = userForm.FirstName;
                user.LastName = userForm.LastName;
                user.BirthDate = userForm.BirthDate;
                user.UserAwards = userForm.UserAwards;
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = _userStorage.GetAll();
            }
        }

        private void ctlDeleteUser_Click(object sender, EventArgs e)
        {
            UserViewModel userView = (UserViewModel)dgvUsers.CurrentRow.DataBoundItem;
            User user = userView.User;
            if (MessageBox.Show($"Удалить пользователя {user.FirstName}?", "Удаление пользователя",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _userStorage.Remove(user);
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = _userStorage.GetAll();
            }
        }

        private void ctlAddAward_Click(object sender, EventArgs e)
        {
            AwardForm awardForm = new AwardForm { Text = "Добавить награду" };
            awardForm.ShowDialog();
            if (awardForm.DialogResult == DialogResult.OK)
            {
                _awardStorage.Add(new Award(awardForm.Title, awardForm.Description));
                dgvAwards.DataSource = null;
                dgvAwards.DataSource = _awardStorage.GetAll();
            }
        }

        private void ctlEditAward_Click(object sender, EventArgs e)
        {
            Award award = (Award)dgvAwards.CurrentRow.DataBoundItem;
            AwardForm awardForm = new AwardForm(award) { Text = "Редактировать награду" };
            awardForm.ShowDialog();
            if (awardForm.DialogResult == DialogResult.OK)
            {
                award.Title = awardForm.Title;
                award.Description = awardForm.Description;
                dgvAwards.DataSource = null;
                dgvAwards.DataSource = _awardStorage.GetAll();
            }
        }

        private void ctlDeleteAward_Click(object sender, EventArgs e)
        {
            Award award = (Award)dgvAwards.CurrentRow.DataBoundItem;
            if (MessageBox.Show($"Удалить награду {award.Title}?", "Удаление награды",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (var user in _userStorage.GetAll())
                {
                    if (user.UserAwards.Contains(award))
                    {
                        user.UserAwards.Remove(award);
                    }
                }
                _awardStorage.Remove(award);
                dgvAwards.DataSource = null;
                dgvAwards.DataSource = _awardStorage.GetAll();
            }
        }

        private void SortUsersByFirstNameAsc()
        {
            _userStorage = new UserStorage(_userStorage.GetAll().OrderBy(u => u.FirstName).ToList());
        }

        private void SortUsersByFirstNameDesc()
        {
            _userStorage = new UserStorage(_userStorage.GetAll().OrderByDescending(u => u.FirstName).ToList());
        }

        private void SortUsersByLastNameAsc()
        {
            _userStorage = new UserStorage(_userStorage.GetAll().OrderBy(u => u.LastName).ToList());
        }

        private void SortUsersByLastNameDesc()
        {
            _userStorage = new UserStorage(_userStorage.GetAll().OrderByDescending(u => u.LastName).ToList());
        }

        private void SortUsersByAgeAsc()
        {
            _userStorage = new UserStorage(_userStorage.GetAll().OrderBy(u => u.Age).ToList());
        }

        private void SortUsersByAgeDesc()
        {
            _userStorage = new UserStorage(_userStorage.GetAll().OrderByDescending(u => u.Age).ToList());
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
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _userStorage.GetAll();
        }
    }
}
