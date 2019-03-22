using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class PlayField
    {
        private int width;
        private int height;

        public int Width
        {
            get { return this.width; }

            set
            {
                if (value >= 20)
                {
                    this.width = value;
                }
                else
                {
                    throw new Exception("Incorrect width");
                }
            }
        }

        public int Height
        {
            get { return this.height; }

            set
            {
                if (value >= 20)
                {
                    this.height = value;
                }
                else
                {
                    throw new Exception("Incorrect width");
                }
            }
        }

        public PlayField() : this(20, 20)
        {
        }

        public PlayField(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
