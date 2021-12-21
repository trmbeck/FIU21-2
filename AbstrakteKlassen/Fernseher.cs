using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal class Fernseher : ElektrischesGeraet
    {
        public Fernseher(double leistung)
        {
            leistungsaufnahme = leistung;
        }
        public override void Ausschalten()
        {
            Console.WriteLine("Fernseher ausgeschaltet");
        }

        public override void Einschalten()
        {
            start = DateTime.Now;
            Console.WriteLine("Bild anzeigen");
        }
    }
}
