using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Monster : Somebody, IMovable
    {
        public Monster(int x, int y) : base(x, y)
        {
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Destroy(Player player)
        {

        }
    }
}
