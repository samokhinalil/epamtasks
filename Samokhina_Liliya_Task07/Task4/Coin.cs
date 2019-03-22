using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Coin : Somebody
    {
        public int Cost { get; set; }

        public Coin(int x, int y, int cost) : base(x, y)
        {
            Cost = cost;
        }

    }
}
