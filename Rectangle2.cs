using System;
using System.Collections.Generic;
using System.Text;

namespace JBQA1
{
    class Rectangle
    {
        public int getLength(int length)
        {
            if (length == 0)
            {
                length = 1;
            }

            return length;
        }

        public int setLength(int length)
        {
            if (length < 1)
            {
                length = 1;
            }
            return length;
        }

        public int getWidth(int width)
        {
            if (width == 0)
            {
                width = 1;
            }
            return width;
        }

        public int setWidth(int width)
        {
            if (width < 1)
            {
                width = 1;
            }
            return width;
        }

        public int getPerimeter(int length, int width)
        {
            return 2 * (length * width);
        }

        public int getArea(int length, int width)
        {
            return width * length;
        }

    }
}
