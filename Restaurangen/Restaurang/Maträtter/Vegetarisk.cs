using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang.Maträtter
{
    internal class Vegetarisk : Maträtt
    {
        internal Vegetarisk(string namn, int pris, int kvalité, int destination_bord) : base(namn,pris, kvalité, destination_bord)
        {
            Namn = namn;
            Pris = pris;
            Kvalité = kvalité;
            Destination_bord = destination_bord;
        }
    }
}
