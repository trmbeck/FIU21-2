// See https://aka.ms/new-console-template for more information
using Polymorphie;

//AbgeleiteteKlasse klasseobjekt = new AbgeleiteteKlasse();
//klasseobjekt.kommazahl = 1.5F;
//klasseobjekt.text = "text Feld der abgeleiteten Klasse";
//klasseobjekt.zeichen = 'a';
////klasseobjekt.zahl = 12;

//Console.WriteLine("Objekt der Abgeleiteten Klasse:\n--------------------------------------");
//klasseobjekt.test();
//klasseobjekt.test2();


//Basisklasse basisobjekt = klasseobjekt;
//Console.WriteLine("\n\nObjekt der Abgeleiteten Klasse in Basisklassenvariable:\n--------------------------------------");
//basisobjekt.test();
//basisobjekt.test2();

Console.WriteLine("Polymorphie");

Notebook meinNotebook = new Notebook();
Console.WriteLine("meinNotebook ein- und ausschalten: ");
meinNotebook.einschalten();
meinNotebook.ausschalten();

Computer meinComputer = new Computer();
Console.WriteLine("\nmeinComputer ein- und ausschalten: ");
meinComputer.einschalten();
meinComputer.ausschalten();

Console.WriteLine("\nNotebookobjekt in ein Computerobjekt speichern!");
meinComputer = meinNotebook;
Console.WriteLine("meinComputer mit meinNotebookobjekt ein- und ausschalten: ");
meinComputer.einschalten();
meinComputer.ausschalten();

Console.Clear();

Computer[] computerListe = new Computer[3];
computerListe[0] = meinNotebook;

Workstation meineWorkstation = new Workstation();
computerListe[1] = meineWorkstation;

computerListe[2] = new Server();

for (int i=0; i < computerListe.Length; i++)
{
    
    if (computerListe[i] is Notebook notebook)
    {
        notebook.einschalten();
        //(computerListe[i] as Notebook).einschalten();
        continue;
    } 

    computerListe[i].einschalten();
}
Console.WriteLine();
for (int i=0; i < computerListe.Length; i++)
{
    computerListe[i].ausschalten();
}