using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngestlltenGehaltAuszahlen
{
    internal class Manager : Angestellter
    {
        public override void GehaltAuszahlen()
        {
            Console.WriteLine("Gehalt für Manager: 1000 Euro überwiesen");
        }
    }
}
