using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_Lagerhaltung
{
    class Artikel
    {
        private long artikel_nr;
        private string bezeichung;
        private long bestand;
        private long min_bestand;
        public long Artikel_nr { get; set; }
        public string Bezeichung { get; set; }
        public long Bestand { get; set; }
        public long Min_bestand { get; set; }

        // 1 Artikel -> * Bestellpositionen
        private List<Bestellposition> _bestellpositionen = new List<Bestellposition>();

        public void BestellpositionHinzufuegen(Bestellposition bestellposition)
        {
            _bestellpositionen.Add(bestellposition);
        }

        public void AlleBestellpositionenEntfernen()
        {
            foreach (var bestellposition in _bestellpositionen)
                _bestellpositionen.Remove(bestellposition);
        }

        // 1 Artikel -> * Lieferkonditionen
        private List<Lieferkondition> _lieferkonditionen = new List<Lieferkondition>();

        public void LieferkonditionHinzufuegen(Lieferkondition lieferkondition)
        {
            _lieferkonditionen.Add(lieferkondition);
        }

        public void AlleLieferkonditionenEntfernen()
        {
            foreach (var lieferkondition in _lieferkonditionen)
                _lieferkonditionen.Remove(lieferkondition);
        }
    }
}
