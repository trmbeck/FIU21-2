// See https://aka.ms/new-console-template for more information


        Console.WriteLine("Hello, World!");

        // Objektorientierte Programmierung (OOP)
        // C -> C++, C#, Java
        // Pascal -> Delphi
        // Basic -> VisualBasic
        // Python

        // Funktionelle Programmierung
        // Haskel, F#

        //Datenstrukturen
        // Ganzzahlen
        int meinGanzzahlwert = 10; // 4Byte -> -2,17 bis 2,17 Mrd. 

        // Gleitkommazahlen
        double Gleitkommazahl = 10.0;

        string Zeichenkette = "Hallo FIU 21/2";

        bool WahrOderFalsch = true;

        int Groesse = 5;
        int[] GanzzahlContainer = new int[Groesse]; // Array
        GanzzahlContainer[0] = 123;
        GanzzahlContainer[1] = 42;
        GanzzahlContainer[2] = 0;
        GanzzahlContainer[3] = 8;
        GanzzahlContainer[4] = 15;

        /*
         y  ^
            |
            |
            |
         10 |
            |
            |
            |
            |
         5  |
            |
            |
            |    P
            |
            +-------------------------------------------------------->
                 5     10    15    20 ...                            x

        P(5|2)

         */

        double x = 5.0; // 5 ist ein Literal
        double y = 2;
        
        double[] P = new double[2];
        P[0] = 5;
        P[1] = 2;

        Punkt P1 = new Punkt(); //P1 ist ein Objekt
        P1.x = 5.0;
        P1.y = 2;

        Console.WriteLine($"Punkt 1: Wert {P1.x} auf X-Achse");
        Console.WriteLine("Punkt 1 y-Wert: {0}",P1.y);

class Punkt
{
    //Member
    public double x;
    public double y;
}


