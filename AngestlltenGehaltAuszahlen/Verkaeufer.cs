using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngestlltenGehaltAuszahlen
{
    internal class Verkaeufer : Angestellter
    {
        public override void GehaltAuszahlen()
        {
            Console.WriteLine("Gehalt für VerkäuferIn: 2500 Euro überwiesen");
        }
    }
}
