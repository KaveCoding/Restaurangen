using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Restaurangen.People.Gäst;

namespace Restaurangen.People
{
    internal class Gäst : Person
    {
        static Random random = new Random();
        internal static string[] ArrayNameList = { "Mohammed", "Thom", "Bilal", "Daniel", "Erik", "Elias", "Emma", "Kenneth", "Andersson", "Johansson", "Karlssson","Nillsson", "Eriksson"
            , "Larsson","Olsson","Persson","Svensson","Gustavsson","Petterson","Johnsson","Jansson","Hansson","Bengtsson","Jönsson","Lindberg","Jakobsson","Magnusson","´Lindström"
            ,"Olofsson","Lindkvist","Lindgren","Berg","Axelsson","Bergström","Lundberg","Lind","Lundgren","Lundqvist","Mattsson","Berglund","Fredriksson","Samberg","Henriksson"
            ,"Ali","Forsberg","Sjöberg","Walin","Engström","Eklund","Danielsson","Lundin","Håkansson","Björk","Bergman","Gunnarsson","Wikström","Holm","Samuelsson","Isaksson"
            ,"Fransson","Bergkvist","Nyström","Holmberg","Arvidsson","Lövgren","Söderberg","Nyberg","Ahmed","Blomqvist","Classon","Nordström","Hassan","Mårtensson","Lundström"
            ,"Viklund","Björklund","Eliasson","Berggren","Pålsson","Sandström","Nordin","Lund","Falk","Ström","Åberg","Ekström","Hermansson"};

        internal int Mängd_pengar { get; set; }
        internal int Nöjdhet { get; set; }
        internal static List<Sällskap> sällskap = new List<Sällskap>(); 

        public Gäst(string namn, int mängd_pengar, int nöjdhet) : base(namn)
        {
            Name = namn;
            Mängd_pengar = mängd_pengar;
            Nöjdhet = nöjdhet;

            while (true)
            {
                int slumpadtal = random.Next(1, 4);
                if (slumpadtal == 1 || slumpadtal == 3)
                {
                    sällskap = generate_company(slumpadtal);
                    break;
                }
            }

        }

        public static List <Sällskap> generate_company(int number_of_company)

        {
            
            List<Sällskap> company = new List<Sällskap>();
            for (int i = 0; i <= number_of_company; i++)
            {
                Sällskap sällskap = new Sällskap(ArrayNameList[random.Next(0, ArrayNameList.Length - 1)], 1000, random.Next(1, 5));

                company.Add(sällskap);
            }

            return sällskap;
        }

        internal class Sällskap 

        {
            internal int Mängd_pengar { get; set; }
            internal string Name { get; set; }
            internal int Nöjdhet { get; set; }

            public Sällskap(string namn, int mängd_pengar, int nöjdhet )
            {
                Name = namn;
                Mängd_pengar = mängd_pengar;
                Nöjdhet = nöjdhet;
            }
        }

        void ätMat()
        {

        }
    }
}
