using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{
    internal class Bord
    {

        internal int AntalSomFårPlats { get; set; }
        internal int Kvalitet { get; set; }

        public Bord(int antal_som_får_plats, int kvalitet)
        {
            AntalSomFårPlats = antal_som_får_plats;
            Kvalitet = kvalitet;
        }

        // public List<Maträtter> { get; set; }
        //  Nota { get; set; }
    }
}
