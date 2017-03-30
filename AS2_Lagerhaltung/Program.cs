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
            var bestellpositionen = new Bestellposition[3];

            // Arrays befüllen
            for (var i = 0; i < lieferanten.Length; i++)
                lieferanten[i] = new Lieferant();
            lieferanten[0].Adresse = "Sonnenallee 195";
            lieferanten[0].Name = "Manfred Malter";
            lieferanten[0].Tel_nr = "030/123405";
            lieferanten[1].Adresse = "Vinetastraße 17";
            lieferanten[1].Name = "Willi Waltner";
            lieferanten[1].Tel_nr = "030/654321";

            for (var i = 0; i < lieferkonditionen.Length; i++)
                lieferkonditionen[i] = new Lieferkondition();
            lieferkonditionen[0].EkPreis = 2.70;
            lieferkonditionen[0].FristTage = 28;
            lieferkonditionen[1].EkPreis = 10;
            lieferkonditionen[1].FristTage = 14;
            lieferkonditionen[2].EkPreis = 12;
            lieferkonditionen[2].FristTage = 5;
            lieferkonditionen[3].EkPreis = 150;
            lieferkonditionen[3].FristTage = 14;

            for (var i = 0; i < artikel.Length; i++)
                artikel[i] = new Artikel();
            artikel[0].Artikel_nr = 1001;
            artikel[0].Bezeichung = "Artikel1";
            artikel[0].Bestand = 10;
            artikel[0].Min_bestand = 2;
            artikel[1].Artikel_nr = 1002;
            artikel[1].Bezeichung = "Artikel2";
            artikel[1].Bestand = 7;
            artikel[1].Min_bestand = 8;
            artikel[2].Artikel_nr = 1003;
            artikel[2].Bezeichung = "Artikel3";
            artikel[2].Bestand = 5;
            artikel[2].Min_bestand = 5;

           for (var i = 0; i < bestellpositionen.Length; i++)
               bestellpositionen[i] = new Bestellposition();
            bestellpositionen[0].Anzahl = 8;
            bestellpositionen[1].Anzahl = 5;
            bestellpositionen[2].Anzahl = 10;

            // Umsetzungs-Variante 2 um Bestellpositionen-Liste zu füllen
            var best1 = new Bestellung();
            // statt best1.NeueBestellposition(); best1.SetzeBestellpositionsAnzahl(0, 8);
            best1.NeueBestellposition(8);
            var best2 = new Bestellung();
            best2.NeueBestellposition(5);
            best2.NeueBestellposition(10);

            // ...
            lieferanten[0].LieferkonditionHinzufuegen(lieferkonditionen[0]);
            lieferanten[0].LieferkonditionHinzufuegen(lieferkonditionen[1]);
            lieferanten[1].LieferkonditionHinzufuegen(lieferkonditionen[2]);
            lieferanten[1].LieferkonditionHinzufuegen(lieferkonditionen[3]);
            //lieferanten[0].AlleLieferkonditionenEntfernen();
            lieferanten[0].BestellungHinzufuegen(best1);
            lieferanten[1].BestellungHinzufuegen(best2);

            artikel[0].LieferkonditionHinzufuegen(lieferkonditionen[0]);
            artikel[1].LieferkonditionHinzufuegen(lieferkonditionen[1]);
            artikel[1].LieferkonditionHinzufuegen(lieferkonditionen[2]);
            artikel[2].LieferkonditionHinzufuegen(lieferkonditionen[3]);
            //artikel[0].AlleLieferkonditionenEntfernen();

            artikel[1].BestellpositionHinzufuegen(bestellpositionen[0]);
            artikel[1].BestellpositionHinzufuegen(bestellpositionen[2]);
            artikel[2].BestellpositionHinzufuegen(bestellpositionen[1]);



            Console.Write("AnzahlAllerBestellungen: " + Bestellung.GetAnzahlAllerBestellungen());

            Console.ReadLine();
        }
    }
}
