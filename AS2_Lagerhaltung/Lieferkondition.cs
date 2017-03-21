using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2_Lagerhaltung
{
    class Lieferkondition
    {
        private double ek_preis;
        private string frist;

        public double Ek_preis { get; set; }
        public string Frist { get; set; }

        /* DELETE
         private List<Artikel> _artikel = new List<Artikel>();

        public void ArtikelHinzufuegen(Artikel artikel)
        {
            _artikel.Add(artikel);
        }
        
        public void AlleArtikelEntfernen()
        {
            foreach (var artikel in _artikel)
                _artikel.Remove(artikel);
        }
        */
    }
}
