using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal class Waschmaschine : ElektrischesGeraet
    {
        public override void Ausschalten()
        {
            Console.WriteLine("Waschmaschine ausgeschaltet");
        }

        public override void Einschalten()
        {
            Console.WriteLine("Waschen");
        }
    }
}
