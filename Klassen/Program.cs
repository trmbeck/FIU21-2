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
 5  |          P2
    |
    |
    |    P1
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

Punkt P1 = new Punkt(); //P1 ist ein Objekt, Instanz, Variable
P1.x = 5.0;             // Mit dem Punktoperator greift man auf die Member zu
P1.y = 2;

Punkt P2;               // P2 ist jetzt noch 'null'
P2 = new Punkt();       // P2 hat jetzt ein Punkt-Objekt gespeichert
P2.x = 10; P2.y = 5;



Console.WriteLine($"Punkt 1: Wert {P1.x} auf X-Achse");
Console.WriteLine("Punkt 1 y-Wert: {0}", P1.y);
Console.WriteLine($"P2 x: {P2.x} y: {P2.y}");

// Eine Klasse beschreibt einen neuen eigenen Datentyp
// Eine Klasse ist ein Bauplan für Objekte
class Punkt //Schlüsselwort class erzeugt eine neue Klasse mit angegebenem Bezeichner
{           
    //Member, member

    //Felder, fields, UML: Attribute
    public double x; //Zugriffsmodifizierer, Sichtbarkeit
    public double y;
    private double z; //Sichtbarkeit private nur innnerhalb der Klasse (Standard)
}


