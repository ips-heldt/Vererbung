using Ips.Vererbung.Allgemein;
using System;

namespace Vererbung.Allgemein
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassB classB = new ClassB();
            //classB.Firstname = "Martin";
            //classB.Name = "Müller";
            //classB.City = "Hannover";

            //Console.WriteLine(classB.GetFullNameAndCity());
            //Console.Read();

            Luftfahrzeug lfz = new Luftfahrzeug()
            {
                Hersteller = "Messerschmidt",
                Typ = "ME109",
                Baujahr = 1938,
                Farbe = "dunkelgrün",
                AnzahlPiloten = 1,
                MaxFlughoehe = 4000
            };

            Wasserfahrzeug wfz = new Wasserfahrzeug()
            {
                Hersteller = "",
                Typ = "",
                Baujahr = 2004,
                Farbe = "weiß",
                Tiefgang = 2,
                BruttoRegisterTonnen = 10000
            };

            Landfahrzeug auto = new Landfahrzeug()
            {
                Hersteller = "VW",
                Typ = "Polo",
                Baujahr = 2000,
                Farbe = "blau",
                Spurbreite = 2,
                Fahrwerk = 5
            };

            Console.WriteLine(lfz.GetProperties());
            Console.WriteLine(wfz.GetProperties());
            Console.WriteLine(auto.GetProperties());

            Console.ReadKey();
        }
    }
}
