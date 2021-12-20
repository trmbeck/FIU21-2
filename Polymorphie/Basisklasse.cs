using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    internal class Basisklasse
    {
        //Attribute
        private string text = String.Empty;
        protected int zahl;
        internal float kommazahl;
        public char zeichen;

        public void test() { Console.WriteLine("Das ist ein Test der Basisklasse"); }

        public void test2() { Console.WriteLine("Das ist ein weiterer Test der Basisklasse"); }
    }
}
