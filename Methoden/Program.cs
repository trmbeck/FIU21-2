// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

PKW auto1 = new PKW();
//auto1.geschwindigkeit = 0;
auto1.maxGeschwindigkeit = 200;
auto1.beschleunigen(1000,true);
Console.WriteLine("v = " + auto1.GetGeschwindigkeit());
auto1.beschleunigen(-100,false);
Console.WriteLine("v = " + auto1.GetGeschwindigkeit());
auto1.beschleunigen(20,true);
Console.WriteLine("v = " + auto1.GetGeschwindigkeit());
auto1.beschleunigen(-50,false);
Console.WriteLine("v = " + auto1.GetGeschwindigkeit());
