using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektKonstruktion
{
    class Spieler
    {
        // Konstruktor
        // - Muss Name der Klasse haben und mit Klammernpaar ausgestattet sein
        // - Code der beim Erzeugen eines Objekts ausgeführt wird
        // - Konstruktoren können individuell erstellt werden
        // - Standardkonstruktor ist vorhanden, falls es keinen individuellen Konstruktor gibt
        public Spieler(string n)
        {
            punkte = 3;
            name = n;
        }

        public Spieler(int p) : this("Max Mustermann", p) // Konstruktorverkettung: Aufruf eines Konstruktors mit entsprechender Parameterliste
        {
            //punkte = p;
        }

        public Spieler(string n, int p) // Überladung des Konstruktors durch andere Parameterliste
        {
            punkte = p;
            name = n;
        }

        private int punkte;
        private string name;

        public int GetPunkte()
        {
            return punkte;
        }

        //public void SetName(string n)
        //{
        //    name = n;
        //}

        public string GetName()
        {
            return name;
        }
    }
}
