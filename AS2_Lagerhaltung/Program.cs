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

            // Arrays befüllen
            for (var i = 0; i < lieferanten.Length; i++)
                lieferanten[i] = new Lieferant();
            for (var i = 0; i < lieferkonditionen.Length; i++)
                lieferkonditionen[i] = new Lieferkondition();
            for (var i = 0; i < artikel.Length; i++)
                artikel[i] = new Artikel();

            // ...
            lieferanten[0].LieferkonditionHinzufuegen(lieferkonditionen[0]);
            lieferanten[1].LieferkonditionHinzufuegen(lieferkonditionen[2]);
            lieferanten[1].LieferkonditionHinzufuegen(lieferkonditionen[3]);
            lieferanten[0].LieferkonditionenEntfernen();

            lieferkonditionen[0].ArtikelHinzufuegen(artikel[0]);
            lieferkonditionen[1].ArtikelHinzufuegen(artikel[2]);
            lieferkonditionen[1].ArtikelHinzufuegen(artikel[1]);
            lieferkonditionen[0].ArtikelEntfernen();


            //Komposition
            Bestellung bestellung = new Bestellung();
            bestellung.NeueBestellposition();

            Console.ReadLine();
        }
    }
}
