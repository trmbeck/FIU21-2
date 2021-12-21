using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal abstract class ElektrischesGeraet
    {
        protected DateTime start;
        protected double leistungsaufnahme;

        public abstract void Einschalten();

        public abstract void Ausschalten();

        public double VerbrauchBerechnen()
        {
            double energie = (DateTime.Now - start).TotalSeconds / 3600 * leistungsaufnahme;
            return energie;
        }

    }
}
