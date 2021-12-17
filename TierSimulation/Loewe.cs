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
        public Loewe(int puls, int saett, string fellfarbe)// : base(puls,saett)
        {
           this.puls = puls;
           //TODO: saettigung und fellfarbe initialisieren
        }

        public bool Jagen(Tier tier)
        {
            Random random = new Random(); //Zufallszahl
            if (random.Next(0, 100) < 10)
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
            MessageBox.Show("MIAUUU!!!!");
        }
        public string GetFellfarbe()
        {
            return fellfarbe;
        }
        public void SetFellfarbe(string f)
        {
            fellfarbe = f;
        }
        //TODO: Setter und Getter für SChwanz
    }
}
