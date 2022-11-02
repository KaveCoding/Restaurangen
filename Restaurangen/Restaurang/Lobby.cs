using Restaurangen.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{
    internal class Lobby
    {
        private List<Bord> tableList { get; set; }
        private List<Waiter>waiterList { get; set; }
        private List<Company>companyWaitingList { get; set; }
        private int counterRestaurant { get; set; }

        Lobby (List<Bord> TableList)
        {
            TableList = tableList;
        }
        Lobby (List<Waiter> WaiterList)
        {
            WaiterList = waiterList;
        }
        Lobby (List<Company> CompanyWaitingList)
        {
            CompanyWaitingList = companyWaitingList;
        }
        public Lobby (int CounterRestaurant)
        {
            CounterRestaurant = counterRestaurant;
        }

        public static void LobbyRun()
        {

        }
        //public static void PrintMe()
        //{

        //}
        public static void Count()
        {

        }
        public static void DrawArray()
        {

        }
    }
}
