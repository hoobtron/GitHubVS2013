using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_Lagerhaltung
{
    class Bestellung
    {
        // Klassen-Variable
        private static int anzahlAllerBestellungen = 0;

        // Instanz-Variablen
        private long best_nr;
        private DateTime datum;

        // Eigenschaften (extern nur lesbar)
        public long BestNr { get; private set; }
        public DateTime Datum { get; private set; }

        // 1 Bestellung -> * Bestellpositionen
        private List<Bestellposition> _bestellpositionen = new List<Bestellposition>();

        // Standard-Konstruktor
        public Bestellung()
        {
            // Gesamtzahl aller Bestellungen erhöhen
            anzahlAllerBestellungen++;

            // Instanz-Variablen setzen
            BestNr = anzahlAllerBestellungen;
            Datum = DateTime.Today;

            // TODO: ??? Bestellposition schon direkt beim Erzeugen der Bestellung anlegen?
            //NeueBestellposition();
        }

        public static int GetAnzahlAllerBestellungen()
        {
            return anzahlAllerBestellungen;
        }

        // ...
        public void NeueBestellposition()
        {
            var bestellposition = new Bestellposition();
            _bestellpositionen.Add(bestellposition);
        }

        public void SetzeBestellpositionsAnzahl(int index, int anzahl)
        {
            _bestellpositionen[index].Anzahl = anzahl;
        }

        // überladene Methode
        public void NeueBestellposition(int anzahl)
        {
            NeueBestellposition();
            SetzeBestellpositionsAnzahl(_bestellpositionen.Count - 1, anzahl);
        }
    }
}
