using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEnd_project
{
    internal class Program
    {
        //Main function:
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            int choice = 0;

            while (choice != 6)
            {
                Console.WriteLine("Enter 1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name 5.Get All Players: 6.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Player Id: ");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Player Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        team.Add(new Player { PlayerId = ID, PlayerName = name, PlayerAge = age});
                        Console.WriteLine("player added Successfully");
                        Console.Write("Do you want to continue (yes/no)? ");
                        string userInput = Console.ReadLine().ToLower();

                        if (userInput == "yes" || userInput == "y")
                        {
                            Console.WriteLine("Continuing...");
                            // Add code here to continue with the program
                        }
                        else
                        {
                            Console.WriteLine("Exiting the program.");
                            // Add code here to exit the program
                        }
                        break;
                    case 2:
                        Console.Write("Enter Player Id to Remove: ");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        team.Remove(Id);
                        Console.WriteLine("Player removed successfully");
                        Console.Write("Do you want to continue (yes/no)? ");
                        string userInput1 = Console.ReadLine().ToLower();

                        if (userInput1 == "yes" || userInput1 == "y")
                        {
                            Console.WriteLine("Continuing...");
                            // Add code here to continue with the program
                        }
                        else
                        {
                            Console.WriteLine("Exiting the program.");
                            // Add code here to exit the program
                        }
                        break;
                    case 3:
                        Console.Write("Enter Player Id to Get: ");
                        ID = Convert.ToInt32(Console.ReadLine());
                        Player playerById = team.GetPlayerById(ID);
                        if (playerById != null)
                            Console.WriteLine($"Player Name: {playerById.PlayerName}, Age: {playerById.PlayerAge}");
                        else
                            Console.WriteLine("Player Not Found");
                        Console.Write("Do you want to continue (yes/no)? ");
                        string userInput3 = Console.ReadLine().ToLower();

                        if (userInput3 == "yes" || userInput3 == "y")
                        {
                            Console.WriteLine("Continuing...");
                            // Add code here to continue with the program
                        }
                        else
                        {
                            Console.WriteLine("Exiting the program.");
                            // Add code here to exit the program
                        }
                        break;
                    case 4:
                        Console.Write("Enter Player Name to Get: ");
                        string nameToGet = Console.ReadLine();
                        Player playerByName = team.GetPlayerByName(nameToGet);
                        if (playerByName != null)
                            Console.WriteLine($"Player Id: {playerByName.PlayerId}, Age: {playerByName.PlayerAge}");
                        else
                            Console.WriteLine("Player Not Found");
                        Console.Write("Do you want to continue (yes/no)? ");
                        string userInput4 = Console.ReadLine().ToLower();

                        if (userInput4 == "yes" || userInput4 == "y")
                        {
                            Console.WriteLine("Continuing...");
                            // Add code here to continue with the program
                        }
                        else
                        {
                            Console.WriteLine("Exiting the program.");
                            // Add code here to exit the program
                        }
                        break;
                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        foreach (Player player in allPlayers)
                            Console.WriteLine($"Player Id: {player.PlayerId}, Name: {player.PlayerName}, Age: {player.PlayerAge}");
                        Console.Write("Do you want to continue (yes/no)? ");
                        string userInput5 = Console.ReadLine().ToLower();

                        if (userInput5 == "yes" || userInput5 == "y")
                        {
                            Console.WriteLine("Continuing...");
                            // Add code here to continue with the program
                        }
                        else
                        {
                            Console.WriteLine("Exiting the program.");
                            // Add code here to exit the program
                        }
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
