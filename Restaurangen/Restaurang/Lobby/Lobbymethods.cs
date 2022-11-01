using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang.Lobby
{
    public class Lobbymethods
    {
        internal class Lobby
        {

            public static List<Bord> generateTables(List<Bord> listname, int numberOfTables, int size_of_small_table, int size_of_big_table)
            {
                int tablenumber = 0;
                for (int i = 0; i < numberOfTables; i++)
                {
                    Random random = new Random();
                    Bord bord = new Bord(size_of_small_table, random.Next(1, 5), tablenumber); 
                    listname.Add(bord);
                    tablenumber++;
                }
                for (int i = 0; i < numberOfTables; i++)
                {
                    Random random = new Random();
                    Bord bord = new Bord(size_of_big_table, random.Next(1, 5), tablenumber); 
                    listname.Add(bord);
                    tablenumber++;
                }

                List<Bord> Generated_tables = generateTables(listname, 5, 2, 4);
                foreach (Bord bord in Generated_tables)
                {
                    listname.Add(bord);
                }
                return listname;

            }

           //public static List<Bord> create_Tables()
           // {
           //     List<Bord> tables = new List<Bord>();
           //     List<Bord> Generated_tables = generateTables(tables, 5, 2,4);

           //     foreach (Bord bord in Generated_tables)
           //     {
           //         tables.Add(bord);
           //     }                
           //     return tables;
           // }
        }

    }
}
