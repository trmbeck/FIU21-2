using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    internal class AbgeleiteteKlasse : Basisklasse
    {
        public string text = String.Empty;
        
        //Ausblenden oder Verbergen
        new protected int zahl;                
        new public void test()
        { 
            base.test();
            Console.WriteLine("Das ist ein Test der ABGELEITETEN Klasse");
        }

        new public void test2()
        {
            Console.WriteLine("Das ist ein weiterer Test der ABGELEITETEN Klasse");
        }
       
    }
}
