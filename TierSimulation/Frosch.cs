using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierSimulation
{
    internal class Frosch : Tier
    {
        //Attribute
        private int maxLautstaerke;         //default int = 0
        private bool istGiftig;             //default boolean -> false
        private int entwicklungsstufe = 1;  // 1 = Kaulquappe, 2 = Frosch

        //Getter
        public int GetMaxLautstaerke()
        {
            return maxLautstaerke;
        }
        public bool GetIstGiftig()
        {
            return istGiftig;
        }
        public int GetEntwicklungsstufe()
        {
            return entwicklungsstufe;
        }
        public string GetEntwicklungsstufeBezeichnung()
        {
            if (entwicklungsstufe == 1) return "Kaulquappe";
            return "Frosch";
        }

        //Setter
        public void SetMaxLautstaerke(int l)
        {
            maxLautstaerke = l;
        }
        public void SetIstGiftig(bool g)
        {
            istGiftig = g;
        }
        public void SetEntwicklungsstufe(int e)
        {
            if (e > 0 && e < 3)
                entwicklungsstufe = e;
        }
        public void SetEntwicklungsstufe(string e)
        {
            if (e == "Kaulquappe")
            {
                entwicklungsstufe = 1;
            }
            else
            {
                if (e == "Frosch")
                {
                    entwicklungsstufe = 2;
                }
            }
        }

        //Methoden
        public void Quaken(int lautstaerke)
        {
            if (lautstaerke > 0)
            {
                if (lautstaerke > maxLautstaerke)
                { 
                    lautstaerke = maxLautstaerke; 
                }
                MessageBox.Show("Der Frosch quakt mit einer Lautstärke von " + lautstaerke);
            }
        }

        public void Springen(int weite)
        {
            MessageBox.Show($"Frosch springt {weite}m weit");
        }
    }
}
