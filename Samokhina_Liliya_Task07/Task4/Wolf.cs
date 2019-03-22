using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Wolf : Monster, IMovable
    {
        public Wolf(int x, int y) : base(x, y)
        {
        }
    }
}
