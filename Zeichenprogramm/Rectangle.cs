using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeichenprogramm
{
    class Rectangle
    {
        private double x;
        private double y;

        private double a;
        private double b;

        public Rectangle(double x, double y, double a, double b)
        {
            this.x = x;
            this.y = y;
            this.a = a; 
            this.b = b;
        }

        public System.Drawing.Rectangle GetWinFormsRectangle()
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle((int)x,(int)(y-b),(int)a,(int)b);
            return rect;
        }

    }
}
