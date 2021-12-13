// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Heizkoerper heizkoerper1 = new Heizkoerper();
Heizkoerper heizkoerper2 = new Heizkoerper();

do
{
    Console.Clear();
    Console.WriteLine("Heizkörper 1: " + heizkoerper1.GetTemperatur());
    Console.WriteLine("Heizkörper 2: " + heizkoerper2.GetTemperatur());
    Console.WriteLine("1+ Heikörper 1 erhöhen");
    Console.WriteLine("1- Heikörper 1 verringern");

    Console.WriteLine("2+ Heikörper 2 erhöhen");
    Console.WriteLine("2- Heikörper 2 verringern");

    Console.WriteLine("Ihre Wahl");
    string eingabe = Console.ReadLine();

    switch (eingabe)
    {
        case "1+":
            heizkoerper1.Erhoehen();
            break;
        case "1-":
            heizkoerper1.Verringern();
            break;
        case "2+":
            heizkoerper2.Erhoehen();
            break;
        case "2-":
            heizkoerper2.Verringern();
            break;
        case "q":
            return;
        default:
            Console.WriteLine("Falsche Eingabe! Bitte Taste drücken ...");
            Console.ReadKey();
            break;
    }

} while (true);

/*
 * 
 * 
+----------------------------+
| Heizkoerper                |
|----------------------------|
| - aktTemp: double          |
| - reglerstellung: int      |
|                            |
|----------------------------|
| + Verringern()             |
| + Erhoehen()               |
| + GetTemperatur():double   |
+----------------------------+

 */

class Heizkoerper
{
    private double aktTemp = 20;
    private int reglerstellung = 2;

    public void Verringern()
    {
        reglerstellung--;
        if (reglerstellung < 0)
        { 
            reglerstellung = 0;
        }
        else
        {
            aktTemp -= 5;
        }
    }
    public void Erhoehen()
    {
        reglerstellung++;
        if (reglerstellung > 5) reglerstellung = 5;
        else aktTemp += 5;
    }
    public double GetTemperatur()
    {
        return aktTemp;
    }
}