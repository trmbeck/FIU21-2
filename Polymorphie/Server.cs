using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    internal class Server : Computer
    {
        new public void einschalten()
        {
            Console.WriteLine("Server fährt hoch");
        }
        public override void ausschalten()
        {
            Console.WriteLine("Server fährt runter");
        }
    }
}
