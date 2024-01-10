using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEnd_project
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public int PlayerAge { get; set; }
    }
    //Iteam Interface
    public interface ITeam
    {
        void Add(Player player);

        void Remove(int playerId);

        Player GetPlayerById(int playerId);

        Player GetPlayerByName(string playerName);

        List<Player> GetAllPlayers();
    }
    //OneDayTeam Class
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }

        public void Remove(int playerId)
        {
            oneDayTeam.RemoveAll(player => player.PlayerId == playerId);
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.FirstOrDefault(player => player.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.FirstOrDefault(player => player.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
       //Main Function

    }

}

   
