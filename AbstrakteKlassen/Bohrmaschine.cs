using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal class Bohrmaschine : ElektrischesGeraet
    {
        public override void Ausschalten()
        {
            Console.WriteLine("Bohrmaschine ausgeschaltet");
        }

        public override void Einschalten()
        {
            Console.WriteLine("Bohren");
        }
    }
}
