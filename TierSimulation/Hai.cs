using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierSimulation
{
    internal class Hai : Tier
    {
        private bool schuppen;
        private int anzahlZaehne;
        private int tiefe;

        //Getter
        public bool GetSchuppen()
        {
            return schuppen;
        }
        public int GetAnzahlZaehne()
        {
            return anzahlZaehne;
        }
        public int GetTiefe()
        {
            return tiefe;
        }
        //Setter
        public void SetSchuppen(bool sch)
        {
            schuppen = sch;
        }
        public void SetAnzahlZaehne(int anzahl)
        {
            anzahlZaehne = anzahl;
        }
        public void SetTiefe(int t)
        {
            tiefe = t;
        }

        public void Schwimmen(int tief)
        {
            tiefe = tief;
            MessageBox.Show($"Der Hai schwimmt {tiefe}m tief");
        }

        public bool Jagen(Tier tier)
        {
            int wahrscheinlichkeit = 0;

            if (tier is Loewe) wahrscheinlichkeit = 1;
            if (tier is Storch) wahrscheinlichkeit = 20;
            if (tier is Frosch) wahrscheinlichkeit = 50;

            Random random = new Random(); //Zufallszahl
            if (random.Next(0, 100) <= wahrscheinlichkeit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
