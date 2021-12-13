// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

PKW auto1 = new PKW();
//auto1.geschwindigkeit = 0;
auto1.maxGeschwindigkeit = 200;
auto1.beschleunigen(1000);
auto1.beschleunigen(-100);
auto1.beschleunigen(20);
auto1.beschleunigen(-50);
//auto1.geschwindigkeit = 1200;

//Console.WriteLine("aktuelle V: " + auto1.geschwindigkeit);

class PKW
{
    //UML: Attribute, C#: Felder
    public string antriebsart;
    public int leistung;
    private double geschwindigkeit;
    public double maxGeschwindigkeit;

    //UML: Operationen, C#: Methoden
    public void beschleunigen(double a)
    {
        geschwindigkeit = geschwindigkeit + a;
        if (geschwindigkeit > maxGeschwindigkeit)
        {
            Console.WriteLine($"Maximalgeschwindigkeit von {maxGeschwindigkeit}km/h erreicht!");
            geschwindigkeit = maxGeschwindigkeit;

        }
        Console.WriteLine("V = " + geschwindigkeit);
    }
}