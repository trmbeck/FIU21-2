// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vektor2D v = new Vektor2D();
v.SetX(10);
v.SetY(20);
Console.WriteLine(v.GetX());
Console.WriteLine(v.GetY());

class Vektor2D
{
    private double x;
    private double y;

    public double GetX()
    {
        return x;
    }

    public double GetY()
    {
        return y;
    }

    public void SetX(double wert)
    {
        x = wert;
    }

    public void SetY(double wert)
    {
        y = wert;
    }
}