using Restaurangen.People;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{

    internal class Lobby
    {
        public static Random random = new Random();
        public static string[] ArrayNameList = { "Mohammed", "Thom", "Bilal", "Daniel", "Erik", "Elias", "Emma", "Kenneth", "Andersson", "Johansson", "Karlssson","Nillsson", "Eriksson"
            , "Larsson","Olsson","Persson","Svensson","Gustavsson","Petterson","Johnsson","Jansson","Hansson","Bengtsson","Jönsson","Lindberg","Jakobsson","Magnusson","´Lindström"
            ,"Olofsson","Lindkvist","Lindgren","Berg","Axelsson","Bergström","Lundberg","Lind","Lundgren","Lundqvist","Mattsson","Berglund","Fredriksson","Samberg","Henriksson"
            ,"Ali","Forsberg","Sjöberg","Walin","Engström","Eklund","Danielsson","Lundin","Håkansson","Björk","Bergman","Gunnarsson","Wikström","Holm","Samuelsson","Isaksson"
            ,"Fransson","Bergkvist","Nyström","Holmberg","Arvidsson","Lövgren","Söderberg","Nyberg","Ahmed","Blomqvist","Classon","Nordström","Hassan","Mårtensson","Lundström"
            ,"Viklund","Björklund","Eliasson","Berggren","Pålsson","Sandström","Nordin","Lund","Falk","Ström","Åberg","Ekström","Hermansson"};


        internal List<Guest> Guests { get; set; }
        internal List<Chef> Chefs { get; set; }
        internal List<Waiter> Waiters  { get; set; }
        internal List<Bord> Tables { get; set; }
        internal Queue<Guest> Queue { get; set; }
        internal Kök KökProperty { get; set; }


        public Lobby()
        {
            static List<Bord> generateTables(int numberOfTables, int size_of_small_table, int size_of_big_table)
            {
                List<Bord> tables = new List<Bord>();
                int tablenumber = 0;
                for (int i = 0; i < numberOfTables; i++)
                {
                    Bord bord = new Bord(size_of_small_table, random.Next(1, 5), tablenumber, true);
                    tables.Add(bord);
                    tablenumber++;
                }
                for (int i = 0; i < numberOfTables; i++)
                {
                    Bord bord = new Bord(size_of_big_table, random.Next(1, 5), tablenumber, true);
                    tables.Add(bord);
                    tablenumber++;
                }
                return tables;
            }
            
            this.Tables = generateTables(5, 2, 4);

            static List<Waiter> generateWaiters(int number_of_waiters)

            {
                List<Waiter> waiters = new List<Waiter>();
                for (int i = 0; i < number_of_waiters; i++)
                {

                    Waiter waiter = new Waiter(ArrayNameList[random.Next(0, ArrayNameList.Length - 1)], random.Next(1, 5), false);
                    waiters.Add(waiter);
                }
                return waiters;
            }
            
            this.Waiters = generateWaiters(3);

            static List<Chef> generatechefs(int number_of_chefs)

            {
                List<Chef> chefs = new List<Chef>();
                for (int i = 0; i < number_of_chefs; i++)
                {

                    Chef chef = new Chef(ArrayNameList[random.Next(0, ArrayNameList.Length - 1)], random.Next(1, 5));
                    chefs.Add(chef);

                 }

                return chefs;
            }

            this.Chefs = generatechefs(5);

            static List<Guest> generateguests(int number_of_guests)

            {
                List<Guest> guests = new List<Guest>();
                for (int i = 0; i < number_of_guests; i++)
                {

                    Guest newgäst = new Guest(ArrayNameList[random.Next(0, ArrayNameList.Length - 1)], 1000, random.Next(1, 5));

                    guests.Add(newgäst);
                }

                return guests;
            }

            this.Guests  = generateguests(30);

            Queue<Guest> queue = new Queue<Guest>();

            Queue<Guest> Add_guests_to_queue(Queue<Guest> queue)
            {
                foreach (Guest guest in Guests)
                {
                    queue.Enqueue(guest);
                }
                return queue;
            }

            this.Queue = Add_guests_to_queue(queue);

            this.KökProperty = KökProperty;


        }
           
       
    }
    }
        
    

