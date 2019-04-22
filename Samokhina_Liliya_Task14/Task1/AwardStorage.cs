using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AwardStorage : IStorage<Award>
    {
        private List<Award> _awards = new List<Award>();

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
