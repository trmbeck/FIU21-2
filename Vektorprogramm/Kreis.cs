using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorprogramm
{
    internal class Kreis : Vektorgrafik
    {
        double mittelpunktX;
        double mittelpunktY;
        public override void Verschieben(double deltaX, double deltaY)
        {
            posx += deltaX;
            posy += deltaY;
            mittelpunktX += deltaX;
            mittelpunktY += deltaY;
            Console.WriteLine("Kreis verschoben!");
        }
    }
}
