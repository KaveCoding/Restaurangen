using Restaurangen.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang.Lobby
{
   

    internal class Lobby
    {

        List<Bord> All_tables = Lobbymethods.Lobby.create_Tables();    //alla bord är sparade här!

        List<Waiter> waiters = new List<Waiter>();

        List<Kock> chefs = new List<Kock>();

        List<Gäst> guests = new List<Gäst>();

        Kök kitchen = new Kök(false);
    }


    }

