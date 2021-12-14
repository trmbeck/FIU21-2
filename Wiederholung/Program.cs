// See https://aka.ms/new-console-template for more information
using System;

namespace Wiederholung
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            //Objektmethode
            Program meinObjekt = new Program();
            meinObjekt.test();
            
            //Klassenmethode
            Program.staticTest();
            //Program.test(); -> geht nicht, test() ist eine Objektmethode
        }

        private void test()
        {
            Console.WriteLine("Methodenaufruf");
        }

        static void staticTest()
        {
            Console.WriteLine("statischer MEthodenaufruf");
        }
    }

}


