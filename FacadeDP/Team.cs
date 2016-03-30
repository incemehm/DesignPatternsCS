using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(player.Name + " kicked off. Game Started!");
        }
    }
}
