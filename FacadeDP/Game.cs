using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP
{
    public class Game
    {
        Ball ball = new Ball();
        Team team = new Team();

        public void KickOff()
        {
            ball.Position = "0,0";
            team.Name = "Beşiktaş JK";
            team.AddPlayer(new Player() { Name = "Gomez" });
            team.AddPlayer(new Player() { Name = "Tore" });
            team.AddPlayer(new Player() { Name = "Quaresma" });
            team.StartWithBall();
         
        }
    }
}
