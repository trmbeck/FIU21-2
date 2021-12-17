// See https://aka.ms/new-console-template for more information
Console.WriteLine("Boxing und Unboxing");
Haus Haus = new Haus();


Blume Tulpe = new Blume();
Kraeuter Basilikum = new Kraeuter();
Baum tannenbaum = new Baum();

Tulpe.groesse = 30;
Basilikum.Giessen();
Tulpe.Giessen();
tannenbaum.Giessen();

Pflanze pflanze = Tulpe;
pflanze.Giessen();
//pflanze.Giessen(true); //Spezialisierung ist nach Boxing nicht mehr vorhanden

//Haus.PflanzenGiessen(Tulpe);
//Haus.PflanzenGiessen(Basilikum);

class Haus
{
    public void PflanzenGiessen(object o)
    {
        if (o.GetType() == typeof(Blume))
        {
            Blume b = (Blume)o;//Unboxing
            b.Giessen();
        }
        else
        {
            if (o is Kraeuter)
            {
                (o as Kraeuter).Giessen();//Unboxing
            }
        }
    }
}

class Pflanze //Basisklasse
{
    public int groesse;
    public void Giessen()
    {
        Console.WriteLine("Pflanze wird gegossen");
    }
}
class Blume : Pflanze // IST-Beziehung, Blume IST eine Pflanze
{
    public void Giessen() // Ausblendung -> Giessen-Methode von Pflanze wird ausgeblendet
    {
        Console.WriteLine("Blume wird gegossen");
    }

    public void Giessen(bool mitDuenger) // Methodenüberladung
    {
        if (mitDuenger) Console.WriteLine("Blume giessen mit Dünger");
        else base.Giessen(); //Aufruf der ausgeblendeten Basisklassen-Methode Giessen()
    }
}

class Kraeuter : Pflanze
{
    new public void Giessen() // Ausblendung ist gewünscht und wird mit Schlüsselwort new gekennzeichnet
    {
        Console.WriteLine("Kräuter werden gegossen");
    }
}

class Baum : Pflanze //Vererbung, Spezialisierung
{

}

class Weizen : Pflanze
{

}

