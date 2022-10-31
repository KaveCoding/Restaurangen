using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{
    internal class Kök
    {
        private bool FoodIsReady { get; set; }



        Kök (bool foodIsReady)
        {
            FoodIsReady = foodIsReady;
        }

    }
}
