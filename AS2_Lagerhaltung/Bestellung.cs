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
        public long Best_nr { get; private set; }
        public DateTime Datum { get; private set; }

        // 1 Bestellung -> * Bestellpositionen
        private List<Bestellposition> _bestellpositionen = new List<Bestellposition>();

        // Standard-Konstruktor
        public Bestellung()
        {
            // Gesamtzahl aller Bestellungen erhöhen
            anzahlAllerBestellungen++;

            // Instanz-Variablen setzen
            Best_nr = anzahlAllerBestellungen;
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
            Bestellposition bestellposition = new Bestellposition();
            this._bestellpositionen.Add(bestellposition);
        }

        public void SetzeBestellpositionsAnzahl(int index, int anzahl)
        {
            this._bestellpositionen[index].Anzahl = anzahl;
        }

        // überladene Methode
        public void NeueBestellposition(int anzahl)
        {
            this.NeueBestellposition();
            this.SetzeBestellpositionsAnzahl(this._bestellpositionen.Count - 1, anzahl);
        }
    }
}
