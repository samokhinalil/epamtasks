using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.Entities;

namespace UsersAndAwards.Storage
{
    public class AwardStorage : IStorage<Award>
    {
        private List<Award> _awards = new List<Award>();

        public AwardStorage()
        {
            Award award1 = new Award("award1", "award1");
            Award award2 = new Award("award2", "award2");
            _awards.Add(award1);
            _awards.Add(award2);
        }

        public AwardStorage(List<Award> awards)
        {
            _awards = awards;
        }

        public void Add(Award item)
        {
            _awards.Add(item);
        }

        public void Remove(Award item)
        {
            _awards.Remove(item);
        }

        public Award GetByID(int index)
        {
            return _awards.FirstOrDefault(a => a.ID == index);
        }
        
        public List<Award> GetAll()
        {
            return _awards;
        }
    }
}
