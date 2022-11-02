using Restaurangen.People;
using Restaurangen.Restaurang;


namespace GUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] todoList = new string[3];
            todoList[0] = "Diska";
            todoList[1] = "Mata katten";
            todoList[2] = "Städa";

            Window.Draw("Att göra", 1, 1, todoList);

            Lobby lobby = new Lobby();
            Console.WriteLine("guestcount: " + lobby.Queue.Count());  //bara för test
            
            
            
        }
    }
}