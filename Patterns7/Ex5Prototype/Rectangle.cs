﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex5Prototype
{
    class Rectangle : IFigure
    {
        int width;
        int height;

        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} і шириною {1}", height, width);
        }
    }
}
