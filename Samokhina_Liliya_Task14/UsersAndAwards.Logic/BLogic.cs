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
        private UserStorage _userStorage = new UserStorage();
        private AwardStorage _awardStorage = new AwardStorage();
        
        public void AddUser(User user)
        {
            _userStorage.Add(user);
        }

        public void AddAward(Award award)
        {
            _awardStorage.Add(award);
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

        public void SetAllUsers(List<User> users)
        {
            _userStorage = new UserStorage(users);
        }

        public void SetAllAwards(List<Award> awards)
        {
            _awardStorage = new AwardStorage(awards);
        }
    }
}
