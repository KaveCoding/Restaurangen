using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{
    internal class Kök
    {
        internal bool FoodIsReady { get; set; }
        //private List<beställningar>  { get; set; }


    public Kök (bool foodIsReady)
        {
            FoodIsReady = foodIsReady;
        }

    }
}
