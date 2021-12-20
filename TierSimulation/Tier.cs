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
        protected int saettigung;

        //Operationen
        public void Bewegen()
        {
            MessageBox.Show("Tier bewegt sich");
        }

        public void Bewegen(string richtung) //Überladung -> gleicher Bezeichner, aber unterschiedliche Parameterliste
        {
            MessageBox.Show($"Tier bewegt sich in Richtung {richtung}");
        }

        public void Bewegen(double geschw) //Überladung
        {
            MessageBox.Show($"Tier bewegt sich mit der Geschwindigkeit von {geschw} km/h");
        }
        public void Fressen(double energiegehalt)
        {
            saettigung = (int)(saettigung + energiegehalt);
        }
        public Tier(int p, int s)
        {
            puls = p;
            saettigung = s;
        }
        public Tier()
        {
            puls = 100;
            saettigung = 100;
        }

        public int GetPuls() // Getter-Methode für puls
        {
            return puls;
        }
        public void SetPuls(int p) //Setter-Methode für puls
        {
            puls = p;
        }
        public int GetSaettigung()
        {
            return saettigung;
        }
        public void SetSaettigung(int s)
        {
            saettigung = s;
        }
    }
}
