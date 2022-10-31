using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang.Maträtter
{
    internal class Maträtt
    {
        internal string Namn { get; set; }
        internal int Pris { get; set; }
        internal int Kvalité { get; set; }
        internal int Destination_bord { get; set; }

        public Maträtt(string namn, int pris, int kvalité, int destination_bord)
        {
            Namn = namn;
            Pris = pris;
            Kvalité = kvalité;
            Destination_bord = destination_bord;
        }

    }
}
