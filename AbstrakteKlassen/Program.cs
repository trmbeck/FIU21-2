// See https://aka.ms/new-console-template for more information
using AbstrakteKlassen;

Console.WriteLine("Hello, World!");

Fernseher fernseher = new Fernseher(150);
fernseher.Einschalten();

ElektrischesGeraet geraet;// = new ElektrischesGeraet();
geraet = new Bohrmaschine();
geraet.Einschalten();

ElektrischesGeraet[] geraeteListe = new ElektrischesGeraet[3];

geraeteListe[0] = geraet; ;
geraeteListe[1] = new Waschmaschine();
geraeteListe[2] = new Spuelmaschine();

for (int i = 0; i < geraeteListe.Length; i++)
{
    geraeteListe[i].Einschalten();
    geraeteListe[i].Ausschalten();
}

Thread.Sleep(3000);
Console.WriteLine($"Fernseher verbrauchte {fernseher.VerbrauchBerechnen():f2} Wh");