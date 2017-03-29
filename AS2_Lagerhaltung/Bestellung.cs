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
        private long datum;

        public long BestNr { get; private set; }
        public long Datum { get; set; }

        // 1 Bestellung -> * Bestellpositionen
        private List<Bestellposition> _bestellpositionen = new List<Bestellposition>();
        
        public Bestellung()
        {
            anzahlAllerBestellungen++;
            BestNr = anzahlAllerBestellungen;

            // TODO: Bestellposition schon direkt bei Erzeugen der Bestellung anlegen?
            NeueBestellposition();
        }

        public static int GetAnzahlAllerBestellungen()
        {
            return anzahlAllerBestellungen;
        }

        public void NeueBestellposition()
        {
            var bestellposition = new Bestellposition();
            _bestellpositionen.Add(bestellposition);
        }
    }
}
