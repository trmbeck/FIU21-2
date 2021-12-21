using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datumsformate
{
    internal abstract class Datum
    {
        protected DateTime datumsWert;
        public abstract void Ausgabe();
    }

    internal class DatumsFormatLang : Datum
    {
        public DatumsFormatLang(DateTime date)
        {
            datumsWert = date;
        }
        public override void Ausgabe()
        {
            Console.WriteLine(datumsWert.ToLongDateString());
        }
    }

    internal class DatumsFormatKurz : Datum
    {
        public DatumsFormatKurz(DateTime date)
        {
            datumsWert = date;
        }
        public override void Ausgabe()
        {
            Console.WriteLine(datumsWert.ToShortDateString());
        }
    }
}
