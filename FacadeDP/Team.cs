using System.Collections.Generic;
using System.Linq;

namespace FacadeDP
{
    public class Team
    {
        public string Name { get; set; }
        List<Player> Players = new List<Player>();

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void StartWithPlayer(Player player)
        {
            System.Console.WriteLine(player.Name + " kicked off. Game Started!");
        }

        public Player GetPlayer(string name)
        {
            return Players.First(x => x.Name == name);
        }
    }
}
