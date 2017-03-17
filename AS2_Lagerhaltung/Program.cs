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
            
            // Arrays befüllen
            for (var i = 0; i < lieferanten.Length; i++)
                lieferanten[i] = new Lieferant();
            for (var i = 0; i < lieferkonditionen.Length; i++)
                lieferkonditionen[i] = new Lieferkondition();
            
            // ...
            lieferanten[0].LieferkonditionHinzufuegen(lieferkonditionen[0]);
            lieferanten[1].LieferkonditionHinzufuegen(lieferkonditionen[2]);
            lieferanten[1].LieferkonditionHinzufuegen(lieferkonditionen[4]);
            lieferanten[0].LieferkonditionenEntfernen();


            //Komposition
            Bestellung bestellung = new Bestellung();
            bestellung.NeueBestellposition();

            Console.ReadLine();
        }
    }
}
