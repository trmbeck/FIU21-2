using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal class Spuelmaschine : ElektrischesGeraet
    {
        public override void Ausschalten()
        {
            Console.WriteLine("Spülmaschine ausgeschaltet");
        }

        public override void Einschalten()
        {
            Console.WriteLine("Spülen");
        }
    }
}
