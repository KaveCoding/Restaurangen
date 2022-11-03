using Restaurangen.People;
using Restaurangen.Restaurang;


namespace GUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printMethod();




            static void printMethod()
            {
                List<string> todoList = new List<string>();

                todoList.Add("Placeholder");

                int bordnummer = 1;
                int distance = 0;
                for (int i = 0; i <= 4; i++)
                {
                    Window.Draw("Bord " + bordnummer, distance, 1, todoList);
                    distance = distance + 20;
                    bordnummer++;
                }

                distance = 0;
                for (int i = 0; i <= 4; i++)
                {
                    Window.Draw("Bord " + bordnummer, distance, 10, todoList);
                    distance = distance + 20;
                    bordnummer++;
                }
            }

            Lobby lobby = new Lobby();

            Console.WriteLine("guestcount: " + lobby.Queue.Count());  //bara för test
            
            
            
        }
    }
}