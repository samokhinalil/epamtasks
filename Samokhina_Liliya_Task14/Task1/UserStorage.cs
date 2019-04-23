using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UserStorage : IStorage<User>
    {
        private List<User> _users = new List<User>();

        public UserStorage()
        {
        }

        public UserStorage(List<User> users)
        {
            _users = users;
        }

        public void Add(User item)
        {
            _users.Add(item);
        }

        public void Remove(User item)
        {
            _users.Remove(item);
        }

        public User GetByID(int index)
        {
            return _users.FirstOrDefault(u => u.ID == index);
        }

        public List<User> GetAll()
        {
            return _users;
        }
    }
}
