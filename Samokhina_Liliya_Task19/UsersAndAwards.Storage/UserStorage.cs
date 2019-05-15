using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.Entities;

namespace UsersAndAwards.Storage
{
    public class UserStorage : IStorage<User>
    {
        private List<User> _users = new List<User>();

        public UserStorage()
        {
            Award award1 = new Award("award1", "award1");
            Award award2 = new Award("award2", "award2");
            User user1 = new User("user1 firstName", "user1 lastName", new DateTime(1998, 10, 27), new List<Award> { award1, award2 });
            User user2 = new User("user2 firstName", "user2 lastName", new DateTime(2000, 10, 25), new List<Award> { award1 });
            User user3 = new User("user3 firstName", "user3 lastName", new DateTime(1995, 10, 23), new List<Award> { award2 });

            _users.Add(user1);
            _users.Add(user2);
            _users.Add(user3);
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

        public List<User> GetAll()
        {
            return _users;
        }

        public void Edit(User item)
        {
            throw new NotImplementedException();
        }
    }
}
