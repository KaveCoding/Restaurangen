using Restaurangen.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{
    internal class Kök
    {
        private List<Kock> KockList { get; set; }

        private bool FoodIsReady { get; set; }

        Kök (List<Kock> kockList)
        {
            KockList = kockList;
        }

        Kök (bool foodIsReady)
        {
            FoodIsReady = foodIsReady;
        }

    }
}
