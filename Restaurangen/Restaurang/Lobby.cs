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
        private List<Bord> tableList = new List<Bord>();
        private List<Waiter>waiterList = new List<Waiter>();
        private List<Company>companyWaitingList = new List<Company>();
        private int counterRestaurant { get; set; }

        Lobby (List<Bord> tableList)
        {
            
        }
        Lobby (List<Waiter> waiterList)
        {

        }
        Lobby (List<Company> companyWaitingList)
        {

        }
        Lobby (int counterRestaurant)
        {

        }

        public static void LobbyRun()
        {

        }
        public static void PrintMe()
        {

        }
        public static void Count()
        {

        }
        public static void DrawArray()
        {

        }
    }
}
