// See https://aka.ms/new-console-template for more information

using AngestlltenGehaltAuszahlen;

namespace AngestlltenGehaltAuszahlen
{
    class Program
    {
        static void Main()
        {

            SekraeterIn sekraeter = new SekraeterIn();
            Manager manager = new Manager();
            Lagerarbeiter lagerarbeiter = new Lagerarbeiter();
            Verkaeufer verkaeufer = new Verkaeufer();


            GehaltUeberweisen(manager);
            GehaltUeberweisen(sekraeter);
            GehaltUeberweisen(lagerarbeiter);
            GehaltUeberweisen(verkaeufer);
        }
        static void GehaltUeberweisen(Angestellter angestellter)
        {
            angestellter.GehaltAuszahlen();
        }
    }
}