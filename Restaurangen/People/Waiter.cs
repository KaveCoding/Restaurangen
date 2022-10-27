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

        internal void Serve()
        {

        }

        internal void GetFood()
        {

        }

        internal void GetDrink()
        {

        }

        internal void GetBill()
        {

        }

        internal void TakePayment()
        {

        }



    }
}
