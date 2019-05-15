using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.Storage;
using UsersAndAwards.Entities;

namespace UsersAndAwards.Logic
{
    public class BLogic
    {
        private IStorage<User> _userStorage = new UserSqlStorage();
        private IStorage<Award> _awardStorage = new AwardSqlStorage();

        public void AddUser(User user)
        {
            _userStorage.Add(user);
        }

        public void AddAward(Award award)
        {
            _awardStorage.Add(award);
        }

        public void EditUser(User user)
        {
            _userStorage.Edit(user);
        }

        public void EditAward(Award award)
        {
            _awardStorage.Edit(award);
        }

        public void RemoveUser(User user)
        {
            _userStorage.Remove(user);
        }

        public void RemoveAward(Award award)
        {
            _awardStorage.Remove(award);
        }

        public List<User> GetAllUsers()
        {
            return _userStorage.GetAll();
        }

        public List<Award> GetAllAwards()
        {
            return _awardStorage.GetAll();
        }
    }
}
