using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{
    internal class Maträtt
    {
        public string Namn { get; set; }
        public int Pris { get; set; }
        public List<string> Allergener { get; set; }
        public int Kvalité { get; set; }
        public int Destination_bord { get; set; }

        Maträtt(string namn, int pris, List<string> allergener, int kvalité, int destination_bord)
        {
            Namn = namn;
            Pris = pris;
            Allergener = allergener;
            Kvalité = kvalité;
            Destination_bord = destination_bord;
        }

    }
}
