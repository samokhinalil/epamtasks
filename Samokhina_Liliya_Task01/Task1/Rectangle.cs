using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle
    {
        private int width;
        private int height;

        public int getWidth()
        {
            return this.width;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public int getHeight()
        {
            return this.height;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int getSquare()
        {
            if (width <= 0 || height <= 0)
            {
                throw new Exception();
            }
            else
            {
                return this.width * this.height;
            }
        }
    }
}
