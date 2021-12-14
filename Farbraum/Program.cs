// See https://aka.ms/new-console-template for more information
using System;

namespace Farbraum
{
    class Program
    {
        static void Main()
        {
            Console.Write("Rot:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grün:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Blau:");
            int b = Convert.ToInt32(Console.ReadLine());

            Farbe meineFarbe = new Farbe(r,g,b);

            Console.WriteLine("RGB-Farbe r:{0} g:{1} b:{2}",
                meineFarbe.GetRot(),
                meineFarbe.GetGruen(),
                meineFarbe.GetBlau()
                );
        }
    }

    class Farbe
    {
        //Felder
        private int rot;
        private int gruen;
        private int blau;

        //Konstruktor
        public Farbe(int r, int gruen, int b)
        {
            //this.rot = r;
            SetRot(r);
            //this.gruen = gruen;
            SetGruen(gruen);
            //this.blau = b;
            SetBlau(b);
        }

        //Getter
        public int GetRot()
        {
            return rot;
        }
        public int GetGruen()
        {
            return gruen;
        }
        public int GetBlau()
        {
            return blau;
        }

        //Setter
        public void SetRot(int r)
        {
            if (r >= 0 && r <=255)
                this.rot = r;   // von 0 bis 255
            else
                Console.WriteLine("Fehler: ungültiger Bereich, Wert muss von 0 bis 255 sein");
        }
        public void SetGruen(int g)
        {
            if (g >= 0 && g <= 255)
                gruen = g;      // von 0 bis 255
            else
            {
                Console.WriteLine("Fehler: ungültiger Bereich, Wert muss von 0 bis 255 sein");
                gruen = 255;
            }
        }
        public void SetBlau(int b)
        {
            blau = b & 255;       // von 0 bis 255

            /*
                    A & B   C             
                    0   0   0
                    0   1   0
                    1   0   0
                    1   1   1


             255dez  ->binär          0000 1111 1111
            1234dez  ->binär          0100 1101 0010
                                     ----------------
                                      0000 1101 0010  -> dez. 210

                             1024 512 256 128 64 32 16 8 4 2 1
            1234 & 255          1   0   0   1  1  0  1 0 0 1 0

             255dez  ->binär          0000 1111 1111
              34dez  ->binär          0000 0010 0010
                                      --------------
                                      0000 0010 0010 -> dez 34
             */
        }
    }
}




