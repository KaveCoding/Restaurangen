using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.People
{
    internal class Kock : Person
    {

        public Kock(string namn, int kompetens) : base(namn)
        {
            Name = namn;
            Kompetens = kompetens;
        }

        internal int Kompetens { get; set; }


        //internal void work()
        //{
        //     void taEmotBeställning()
        //    {

        //    }

        //     void lagaMat()
        //    {

        //    }
        //}
 
    }

    

        
    }

