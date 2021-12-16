using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeichenprogramm
{
    class Circle
    {
        private double x;
        private double y;
        private double radius;

        public Circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public System.Drawing.Rectangle GetWinFormRectangle()
        {
            //Namespaceangabe ist notwendig, weil im Zeichenprogramm ein Rectangle existiert
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(
                (int)(x - radius), 
                (int)(y - radius), 
                (int)(radius * 2.0), 
                (int)(radius * 2.0)
                );
            return rectangle;
        }

        public string GetInfo()
        {
            string info = $"Circle: ({x}|{y}) {radius}";
            return info;
        }
    }
}
