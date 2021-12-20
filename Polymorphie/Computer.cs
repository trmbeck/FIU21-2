using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    internal class Computer
    {
        //Attribute

        //Mehtoden
        public virtual void einschalten()
        {
            Console.WriteLine("Computer fährt hoch");
        }

        public virtual void ausschalten() //virtual kennzeichnet Methode, damit sie überschrieben werden darf
        {
            Console.WriteLine("Computer fährt runter");
        }
    }
}
