using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngestlltenGehaltAuszahlen
{
    internal class Lagerarbeiter : Angestellter
    {
        public override void GehaltAuszahlen()
        {
            Console.WriteLine("Gehalt für Lagerarbeiter: 2000 Euro überwiesen");
        }
    }
}
