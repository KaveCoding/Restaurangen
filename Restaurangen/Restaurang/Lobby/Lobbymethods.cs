using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurangen.Restaurang.Lobby
{
    internal class Lobbymethods
    {
        internal class Lobby
        {
            public static List<Bord> generateTables(List<Bord> listname, int numberOfTables, int size_of_table)
            {
                for (int i = 0; i < numberOfTables; i++)
                {
                    Random random = new Random();
                    Bord bord = new Bord(size_of_table, random.Next(1, 5), 0); //bordnummer sist att fixa;
                    listname.Add(bord);
                }
                return listname;
            }

           public static List<Bord> create_Tables()
            {
                List<Bord> tables = new List<Bord>();
                List<Bord> small_tables = generateTables(tables, 5, 2);
                List<Bord> large_tables = generateTables(tables, 5, 4);

                foreach (Bord bord in small_tables)
                {
                    tables.Add(bord);
                }
                foreach (Bord bord in large_tables)
                {
                    tables.Add(bord);
                }
                return tables;
            }
        }

    }
}
