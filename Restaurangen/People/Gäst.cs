using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurangen.People
{
    internal class Gäst : Person
    {
       
        public Gäst(string namn, int mängd_pengar, int antal_i_sällskapet, int nöjdhet) : base(namn)
        {
            Name = namn;
            Mängd_pengar = mängd_pengar;
            Antal_i_sällskapet = antal_i_sällskapet;
            Nöjdhet = nöjdhet;
        }

        internal int Mängd_pengar { get; set; }
        internal int Antal_i_sällskapet { get; set; }
        internal int Nöjdhet { get; set; }

        void ätMat()
        {

        }
    }
}
