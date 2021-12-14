// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


test t = new test(); //Instanziierung über Standardkonstruktor
t.SetFeld(42);
Console.WriteLine("Feldwert: {0}", t.GetFeld());

class test
{
    private int feld; //gekapselt über Sichbarkeit(Zugriffsmodifizierer) private

    // Getter und Setter Methoden
    // öffentliche Methoden zum Abrufen und Ändern des Wertes eines gekapselten Felds

    //Getter
    public int GetFeld()
    {
        return feld;
    }

    //Setter
    public void SetFeld(int feld)
    {
        // Zuweisung der lokalen Variablen feld zu der Objektvariablen this.feld
        this.feld = feld;
    }
}