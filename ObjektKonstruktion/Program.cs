using System;

namespace ObjektKonstruktion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Name eingeben: ");
            string nameDesSpielers = Console.ReadLine();

            Spieler player = new Spieler(nameDesSpielers);
            //player.SetName(nameDesSpielers);

            Console.WriteLine("Name: " + player.GetName());
            Console.WriteLine("Punkte: " + player.GetPunkte());

            Alien alien = new Alien();
        }

    }
}