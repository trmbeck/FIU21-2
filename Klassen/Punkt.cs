using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    // Eine Klasse beschreibt einen neuen eigenen Datentyp
    // Eine Klasse ist ein Bauplan für Objekte
    class Punkt //Schlüsselwort class erzeugt eine neue Klasse mit angegebenem Bezeichner
    {
        //Mitglieder, member

        //Felder, fields, UML: Attribute
        public double x; //Zugriffsmodifizierer, Sichtbarkeit
        public double y;
        private double z; //Sichtbarkeit private nur innnerhalb der Klasse (Standard)
    }
}
