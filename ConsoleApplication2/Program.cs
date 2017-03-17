using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        class Lieferkondition
        {
            private double ek_preis;
            private string frist;

            public double Ek_preis { get; set; }
            public string Frist { get; set; }

        }
        class Lieferant
        {
            private string name;
            private string adresse;
            private string tel_nr;
            public string Name { get; set; }
            public string Adresse { get; set; }
            public string Tel_nr { get; set; }

            private List<Lieferkondition> _lieferkonditionen = new List<Lieferkondition>();
            public void LieferkonditionHinzufuegen(Lieferkondition lieferkondition)
            {
                _lieferkonditionen.Add(lieferkondition);
            }
            public void LieferkonditionenEntfernen()
            {
                foreach (var lieferkondition in _lieferkonditionen)
                    _lieferkonditionen.Remove(lieferkondition);
            }
        }


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
        class Bestellposition
        {
            //...
            private long anzahl;
            public long Anzahl { get; set; }

        }
        static void Main(string[] args)
        {
            //Komposition
            Bestellung bestellung = new Bestellung();
            bestellung.NeueBestellposition();

            Console.ReadLine();
        }
    }
}
