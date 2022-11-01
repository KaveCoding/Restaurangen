using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.People
{
    internal class Company
    {
        public List<Guest> waitingCompanies { get; set; }
        public int timeWaiting { get; set; }   
    }
}
