// See https://aka.ms/new-console-template for more information
Console.WriteLine("Boxing und Unboxing");
Haus Haus = new Haus();


Blume Tulpe = new Blume();
Kraeuter Basilikum = new Kraeuter();

Haus.PflanzenGiessen(Tulpe);
Haus.PflanzenGiessen(Basilikum);


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

class Blume
{
    public void Giessen()
    {
        Console.WriteLine("Blume wird gegossen");
    }
}

class Kraeuter
{
    public void Giessen()
    {
        Console.WriteLine("Kräuter werden gegossen");
    }
}
