using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_Lagerhaltung
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrays erzeugen (mit [n] items)
            var lieferanten = new Lieferant[2];
            var lieferkonditionen = new Lieferkondition[4];
            var artikel = new Artikel[3];
//            var bestellpositionen = new Bestellpositionen[2];

            // Arrays befüllen
            for (var i = 0; i < lieferanten.Length; i++)
                lieferanten[i] = new Lieferant();
            for (var i = 0; i < lieferkonditionen.Length; i++)
                lieferkonditionen[i] = new Lieferkondition();
            for (var i = 0; i < artikel.Length; i++)
                artikel[i] = new Artikel();
//            for (var i = 0; i < bestellpositionen.Length; i++)
//                bestellpositionen[i] = new Bestellpositionen();


            //Komposition
            Bestellung best1 = new Bestellung();
            best1.NeueBestellposition();
            Bestellung best2 = new Bestellung();
            best2.NeueBestellposition();
            best2.NeueBestellposition();

            // ...
            lieferanten[0].LieferkonditionHinzufuegen(lieferkonditionen[0]);
            lieferanten[0].LieferkonditionHinzufuegen(lieferkonditionen[1]);
            lieferanten[1].LieferkonditionHinzufuegen(lieferkonditionen[2]);
            lieferanten[1].LieferkonditionHinzufuegen(lieferkonditionen[3]);
            //lieferanten[0].AlleLieferkonditionenEntfernen();

            artikel[0].LieferkonditionHinzufuegen(lieferkonditionen[0]);
            artikel[1].LieferkonditionHinzufuegen(lieferkonditionen[1]);
            artikel[1].LieferkonditionHinzufuegen(lieferkonditionen[2]);
            artikel[2].LieferkonditionHinzufuegen(lieferkonditionen[3]);
            //artikel[0].AlleLieferkonditionenEntfernen();
/* ???
            artikel[1].BestellpositionHinzufuegen(bestellpositionen[0]);
            artikel[1].BestellpositionHinzufuegen(bestellpositionen[2]);
            artikel[2].BestellpositionHinzufuegen(bestellpositionen[1]);
/*
            lieferkonditionen[0].ArtikelHinzufuegen(artikel[0]);
            lieferkonditionen[1].ArtikelHinzufuegen(artikel[2]);
            lieferkonditionen[1].ArtikelHinzufuegen(artikel[1]);
            lieferkonditionen[0].AlleArtikelEntfernen();
*/



            Console.Write("AnzahlAllerBestellungen: " + Bestellung.GetAnzahlAllerBestellungen());

            Console.ReadLine();
        }
    }
}
