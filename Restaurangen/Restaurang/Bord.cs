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
        internal int Kvalité { get; set; }
        internal int Bordnummer { get; set; }
        internal bool IsAvailable { get; set; }

        //nota
        //maträtter på bordet

        public Bord(int antal_som_får_plats, int kvalité, int bordnummer, bool isavailable)
        {
            AntalSomFårPlats = antal_som_får_plats;
            Kvalité = kvalité;
            Bordnummer = bordnummer;
            IsAvailable = isavailable;

    }

        // public List<Maträtter> { get; set; }
        //  Nota { get; set; }
    }
}
