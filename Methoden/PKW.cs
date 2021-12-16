// See https://aka.ms/new-console-template for more information

//auto1.geschwindigkeit = 0;
class PKW
{
    //UML: Attribute, C#: Felder
    public string antriebsart;
    public int leistung;
    private double geschwindigkeit;  //Kapselung
    public double maxGeschwindigkeit;

    //UML: Operationen, C#: Methoden
    public void beschleunigen(double a, bool hupen) //Signatur, Definition der Methode
    {//Methodenrumpf
        geschwindigkeit = geschwindigkeit + a;
        if (geschwindigkeit > maxGeschwindigkeit)
        {
            Console.WriteLine($"Maximalgeschwindigkeit von {maxGeschwindigkeit}km/h erreicht!");
            geschwindigkeit = maxGeschwindigkeit;

        }
        if (hupen == true)
        {
            Console.WriteLine("Tröööt!!!!");
        }
    }

    public double GetGeschwindigkeit()
    {
        return geschwindigkeit;
    }
}