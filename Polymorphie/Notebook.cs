using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    internal class Notebook : Computer
    {
        //Attribute

        //Methoden
        new public void einschalten()
        {
            //base.einschalten();
            Console.WriteLine("Notebook fährt hoch");
        }

        public override void ausschalten()
        {
            Console.WriteLine("Notebook fährt runter");
        }
    }
}
