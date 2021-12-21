// See https://aka.ms/new-console-template for more information
using Datumsformate;

Datum datumLang = new DatumsFormatLang(DateTime.Now);
Datum datumKurz = new DatumsFormatKurz(DateTime.Now);

datumLang.Ausgabe();
datumKurz.Ausgabe();
