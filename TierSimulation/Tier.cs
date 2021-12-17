using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierSimulation
{
    class Tier
    {
        //Attribute
        protected int puls;
        //TODO: saettigung implementieren

        //Operationen
        public void Bewegen()
        {
            MessageBox.Show("Tier bewegt sich");
        }

        public void Bewegen(string richtung) //Überladung
        {
            MessageBox.Show($"Tie bewegt sich in Richtung {richtung}");
        }

        public void Bewegen(double geschw) //Überladung
        {
            MessageBox.Show($"Tier bewegt sich mit der Geschwindigkeit von {geschw} km/h");
        }

        //TODO: Fressenmethode implementieren
        public Tier(int p, int s)
        {
            puls = p;
            //TODO: saettigung setzen
        }
        public Tier()
        {

        }

        public int GetPuls()
        {
            return puls;
        }
        public void SetPuls(int p)
        {
            puls = p;
        }
        //TODO: Getter und Setter für saettigung

    }
}
