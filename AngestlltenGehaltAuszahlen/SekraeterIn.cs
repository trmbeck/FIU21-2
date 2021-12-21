using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngestlltenGehaltAuszahlen
{
    internal class SekraeterIn : Angestellter
    {
        public override void GehaltAuszahlen()
        {
            Console.WriteLine("Gehalt für SekräterIn: 3000 Euro überwiesen");
        }
    }
}
