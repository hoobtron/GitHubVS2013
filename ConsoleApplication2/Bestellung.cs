using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_Lagerhaltung
{
    class Bestellung
    {
        private long best_nr;
        private long datum;

        public long Best_nr { get; set; }
        public long Datum { get; set; }


        private List<Bestellposition> _bestellpositionen = new List<Bestellposition>();
        public Bestellung() { NeueBestellposition(); }
        public void NeueBestellposition()
        {
            Bestellposition bestellposition = new Bestellposition();
            _bestellpositionen.Add(bestellposition);
        }
    }
}
