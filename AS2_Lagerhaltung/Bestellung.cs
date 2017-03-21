using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_Lagerhaltung
{
    class Bestellung
    {
        private static int anzahlAllerBestellungen = 0;
        private long best_nr;
        private long datum;

        public long Best_nr { get; private set; }
        public long Datum { get; set; }

        // 1 Bestellung -> * Bestellpositionen
        private List<Bestellposition> _bestellpositionen = new List<Bestellposition>();
        
        public Bestellung()
        {
            anzahlAllerBestellungen++;
            Best_nr = anzahlAllerBestellungen;

            // TODO: Bestellposition schon direkt bei erzeugen der Bestellung anlegen?
            NeueBestellposition();
        }

        public static int GetAnzahlAllerBestellungen()
        {
            return anzahlAllerBestellungen;
        }

        public void NeueBestellposition()
        {
            Bestellposition bestellposition = new Bestellposition();
            _bestellpositionen.Add(bestellposition);
        }
    }
}
