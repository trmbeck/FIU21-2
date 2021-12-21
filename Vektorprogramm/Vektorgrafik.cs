using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorprogramm
{
    internal abstract class Vektorgrafik
    {
        protected string farbe;
        protected string füllmuster;
        protected double posx;
        protected double posy;

        public abstract void Verschieben(double deltaX, double deltaY);

        public string GetFarbe()
        {
            return farbe;
        }

        public void SetFarbe(string farbe)
        {
            this.farbe = farbe;
        }

        // Getter und Setter für alle Attribute ...
    }
}
