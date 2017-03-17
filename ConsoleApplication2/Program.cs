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
            //Komposition
            Bestellung bestellung = new Bestellung();
            bestellung.NeueBestellposition();

            Console.ReadLine();
        }
    }
}
