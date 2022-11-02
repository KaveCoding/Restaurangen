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
        private List<Kock> kockList { get; set; }

        private bool foodIsReady { get; set; }



        Kök (bool FoodIsReady)
        {
            FoodIsReady = foodIsReady;
        }

    }
}
