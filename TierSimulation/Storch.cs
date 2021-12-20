using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierSimulation
{
    internal class Storch : Tier
    {
        private bool federkleid = true;
        private int flughoehe;
        private float spannweite;

        //Getter
        public bool GetFederkleid()
        {
            return federkleid;
        }
        public int GetFlughoehe()
        {
            return flughoehe;
        }
        public float GetSpannweite()
        {
            return spannweite;
        }

        //Setter
        public void SetFederkleid(bool f)
        {
            federkleid = f;
        }
        public void SetFlughoehe(int flughoehe)
        {
            if (flughoehe >= 0)
            {
                this.flughoehe = flughoehe;
            }
        }
        public void SetSpannweite(float sw)
        {
            if (sw > 0)
            {
                spannweite = sw;
            }
        }

        //Methoden
        public void Fliegen(int hoehe)
        {
            SetFlughoehe(hoehe);
            MessageBox.Show($"Der Storch fliegt {GetFlughoehe()}m hoch");
        }

        public void Klappern(int lautstaerke)
        {
            MessageBox.Show("Der Storch klappert mit einer Lautstärke von " + lautstaerke);
        }

        public void NestBauen(string ort, string[] material)
        {
            string nest = "Der Storch baut ein Nest an der Stelle " + ort;
            nest += "\r\nmit den Materialien:\r\n";
            for (int i=0; i < material.Length; i++)
            {
                nest += material[i] + Environment.NewLine;
            }

            MessageBox.Show(nest);

        }
    }
}
