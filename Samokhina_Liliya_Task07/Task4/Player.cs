using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Player : Somebody, IMovable
    {
        private int resourseCount;

        public Player(int x, int y) : base(x, y)
        {
            this.resourseCount = 0;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Shoot(Monster monster)
        {

        }

        public void Eat(Coin bonus)
        {
            this.resourseCount += bonus.Cost;
        }
    }
}
