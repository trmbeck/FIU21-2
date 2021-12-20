using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    internal class Workstation : Computer
    {
        new public void einschalten()
        {
            Console.WriteLine("Workstation fährt hoch");
        }

        public override void ausschalten()
        {
            Console.WriteLine("Workstation fährt runter");
        }
    }
}
