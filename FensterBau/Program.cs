// See https://aka.ms/new-console-template for more information

Console.WriteLine("Fensterbau-Verwaltungssoftware");

Console.WriteLine("Wieviele Fenster? ");
int anzahl = Convert.ToInt32(Console.ReadLine());
Fenster[] fensterliste = new Fenster[anzahl];

for (int zaehler = 0; zaehler < anzahl; zaehler++)
{
    Fenster f = new Fenster();

    f.id = zaehler + 1;

    Console.WriteLine("Zimmer: ");
    f.name = Console.ReadLine();

    Console.WriteLine("Breite: ");
    f.breite = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Höhe: ");
    f.hoehe = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Rahmenfarbe: ");
    f.rahmenfarbe = Console.ReadLine();

    Console.WriteLine("Mehrfachverglasung (J/N): ");
    string eingabe = Console.ReadLine();

    if (eingabe.ToUpper() == "J")
    {
        f.mehrfachverglasung = true;
    }
    else
    {
        f.mehrfachverglasung = false;
    }

    Console.WriteLine("Fensterstärke: ");
    f.staerke = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Material: ");
    f.material = Console.ReadLine();

    fensterliste[zaehler] = f;
}

for (int i = 0; i < fensterliste.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine("ID: " + fensterliste[i].id);
    Console.WriteLine("Name des Zimmers: " + fensterliste[i].name);
    Console.WriteLine("Breite: " + fensterliste[i].breite);
    Console.WriteLine("Höhe: " + fensterliste[i].hoehe);
    Console.WriteLine("Rahmenfarbe: " + fensterliste[i].rahmenfarbe);
    Console.WriteLine("Mehrfachverglasung: " + fensterliste[i].mehrfachverglasung);
    Console.WriteLine("Fensterstärke: " + fensterliste[i].staerke);
    Console.WriteLine("Material: " + fensterliste[i].material);
    Console.WriteLine("----------------------------------------------------\n");
}



//// Exkurs Arrays
//// Beispiel erfassen von Temperatur jede Stunde

//double temp1 = 20.3;
//double temp2 = 20.7;
//double[] temperaturliste = new double[24];
//temperaturliste[4] = 23.4;

class Fenster
{
    public int id;
    public string name;
    public double breite;
    public double hoehe;
    public double staerke;
    public bool mehrfachverglasung;
    public string rahmenfarbe = "weiß"; //weiß ist Standard jetzt
    public string material;

    // Enumeration, Aufzählung
    // "2-fach Verglasung"
    // zum späteren Zeitpunkt

}
