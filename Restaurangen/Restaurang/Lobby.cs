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
        public static string[] ArrayNameList = { "Mohammed", "Thom", "Bilal", "Daniel", "Erik", "Elias", "Emma", "Kenneth", "Andersson", "Johansson", "Karlssson","Nillsson", "Eriksson"
            , "Larsson","Olsson","Persson","Svensson","Gustavsson","Petterson","Johnsson","Jansson","Hansson","Bengtsson","Jönsson","Lindberg","Jakobsson","Magnusson","´Lindström"
            ,"Olofsson","Lindkvist","Lindgren","Berg","Axelsson","Bergström","Lundberg","Lind","Lundgren","Lundqvist","Mattsson","Berglund","Fredriksson","Samberg","Henriksson"
            ,"Ali","Forsberg","Sjöberg","Walin","Engström","Eklund","Danielsson","Lundin","Håkansson","Björk","Bergman","Gunnarsson","Wikström","Holm","Samuelsson","Isaksson"
            ,"Fransson","Bergkvist","Nyström","Holmberg","Arvidsson","Lövgren","Söderberg","Nyberg","Ahmed","Blomqvist","Classon","Nordström","Hassan","Mårtensson","Lundström"
            ,"Viklund","Björklund","Eliasson","Berggren","Pålsson","Sandström","Nordin","Lund","Falk","Ström","Åberg","Ekström","Hermansson"};

        public static List<Bord> generateTables(int numberOfTables, int size_of_small_table, int size_of_big_table)
        {
            List<Bord> tables = new List<Bord>();
            int tablenumber = 0;
            for (int i = 0; i < numberOfTables; i++)
            {
                Random random = new Random();
                Bord bord = new Bord(size_of_small_table, random.Next(1, 5), tablenumber, true); ;
                tables.Add(bord);
                tablenumber++;
            }
            for (int i = 0; i < numberOfTables; i++)
            {
                Random random = new Random();
                Bord bord = new Bord(size_of_big_table, random.Next(1, 5), tablenumber, true);
                tables.Add(bord);
                tablenumber++;
            }
            return tables;
        }

        public static List<Waiter> generateWaiters(int number_of_waiters)

        {
            List<Waiter> waiters = new List<Waiter>();
            for (int i = 0; i < number_of_waiters; i++)
            {
                Random random = new Random();
                Waiter waiter = new Waiter(ArrayNameList[random.Next(0, ArrayNameList.Length - 1)], random.Next(1, 5), false);
                waiters.Add(waiter);
            }
            return waiters;
        }

        public static List<Kock> generatechefs(int number_of_chefs)

        {
            List<Kock> chefs = new List<Kock>();
            for (int i = 0; i <number_of_chefs ; i++)
            {
                Random random = new Random();
                Kock chef = new Kock(ArrayNameList[random.Next(0, ArrayNameList.Length - 1)], random.Next(1, 5));
                chefs.Add(chef);
            }

            return chefs;
        }

        public static List<Gäst> generateguests(int number_of_guests)

        {
            List<Gäst> guests = new List<Gäst>();
            for (int i = 0; i < number_of_guests; i++)
            {
                Random random = new Random();
                Gäst guest = new Gäst(ArrayNameList[random.Next(0, ArrayNameList.Length - 1)], 1000, random.Next(1, 4), random.Next(1,5));
                guests.Add(guest);
            }

            return guests;
        }

        List<Waiter> waiters = new List<Waiter>();

        List<Kock> chefs = new List<Kock>();

        List<Gäst> guests = new List<Gäst>();

        Kök kitchen = new Kök(false);
    }

}

