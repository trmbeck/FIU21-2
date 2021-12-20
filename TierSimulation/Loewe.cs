using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierSimulation
{
    internal class Loewe : Tier
    {
        private string fellfarbe;
        private bool schwanz = true;
        public Loewe(int puls, int saett, string fellfarbe, bool schwanz)// : base(puls,saett)
        {
            this.puls = puls;
            this.saettigung = saett;
            this.schwanz = schwanz;
            this.fellfarbe = fellfarbe;
        }

        public bool Jagen(Tier tier)
        {
            int wahrscheinlichkeit = 0;
            
            if (tier is Hai) wahrscheinlichkeit = 5;
            if (tier is Storch) wahrscheinlichkeit = 60;
            if (tier is Frosch) wahrscheinlichkeit = 95;

            Random random = new Random(); //Zufallszahl
            if (random.Next(0, 100) < wahrscheinlichkeit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Bruellen(int lautstaerke)
        {
            if (lautstaerke < 50)
                MessageBox.Show("MIAUUU!!!!");
            else
                MessageBox.Show("GGGGRRRRRR!!!!!");
        }
        public string GetFellfarbe()
        {
            return fellfarbe;
        }
        public void SetFellfarbe(string f)
        {
            fellfarbe = f;
        }

        public bool GetSchwanz()
        {
            return schwanz;
        }

        public void SetSchwanz(bool s)
        {
            schwanz = s;
        }
    }
}
