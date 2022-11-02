using Restaurangen.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang
{
    internal class Bord
    {
        private string[,] DrawTable { get; set; }
        private int AntalSomFårPlats { get; set; }
        private int Kvalitet { get; set; }
        private Company Company { get; set; }
        private int PositionX { get; set; }
        private int PositionY {get; set; }
        private bool IsAvailable { get; set; }


        public Bord(int antalSomFårPlats, int kvalitet, int positionX, int positionY, bool isAvailable)
        {
            this.DrawTable = new string[4, 20];
            AntalSomFårPlats = antalSomFårPlats;
            Kvalitet = kvalitet;
            PositionX = positionX;
            PositionY = positionY;
            IsAvailable = isAvailable;
        }


        //public List<Maträtter> { get; set; }
        //public int Nota { get; set; }
    }
}
