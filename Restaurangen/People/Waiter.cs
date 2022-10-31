namespace Restaurangen.People
{
    internal class Waiter : Person
    {

        public Waiter(string namn, int servicenivå, bool busy) : base(namn)
        {
            Name = namn;
            Servicenivå = servicenivå;
            Busy = busy;
        }

        private bool Busy { get; set; }
        private int Servicenivå { get; set; }

        internal void work()
        {
             void bemöta_gäst()
            {

            }

             void visa_bord()
            {

            }

             void ge_meny()
            {

            }

             void ta_Beställning()
            {

            }

             void hämta_mat()
            {

            }
             void servera_mat()
            {

            }
             void ta_Emot_Pengar()
            {

            }

             void duka_undan()
            {

            }
        }

        






    }
}
