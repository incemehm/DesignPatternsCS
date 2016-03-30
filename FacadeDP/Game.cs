using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP
{
    public class Game
    {
        public void KickOff()
        {
            Ball ball = new Ball();
            Team team = new Team();

            ball.Position = "0,0";
            team.Name = "Beşiktaş JK";
            team.AddPlayer(new Player() { Name = "Gomez" });
            team.AddPlayer(new Player() { Name = "Tore" });
            team.AddPlayer(new Player() { Name = "Quaresma" });
            team.StartWithPlayer(new Player() { Name="Olcay" });
         
        }
    }
}
