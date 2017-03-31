using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_Lagerhaltung
{
    class Lieferant
    {
        // Attribute
        private string name;
        private string adresse;
        private string tel_nr;

        // Eigenschaften
        public string Name { get; set; }
        public string Adresse { get; set; }
        public string TelNr { get; set; }

        // 1 Lieferant -> * Lieferkonditionen
        private List<Lieferkondition> _lieferkonditionen = new List<Lieferkondition>();

        // 1 Lieferant -> * Lieferkonditionen
        private List<Bestellung> _bestellungen = new List<Bestellung>();

        // Methoden
        public void BestellungHinzufuegen(Bestellung bestellung)
        {
            _bestellungen.Add(bestellung);
        }

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
