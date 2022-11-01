using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{
    internal class Kök
    {


        // internal static List<string> beställningar { get; set; }
        internal bool FoodIsReady { get; set; }
        


    public Kök (bool foodIsReady)
        {
            FoodIsReady = foodIsReady;
        }

    }
}
