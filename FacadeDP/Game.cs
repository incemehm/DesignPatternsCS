namespace FacadeDP
{
    public class Game
    {
        public void KickOff()
        {
            Ball ball = new Ball() { PositionX = 0, PositionY = 0 };
            Team team = new Team() { Name = "Super Heroes" };
            
            team.AddPlayer(new Player() { Name = "SpiderMan" });
            team.AddPlayer(new Player() { Name = "SuperMan" });
            team.AddPlayer(new Player() { Name = "Batman" });
            team.AddPlayer(new Player() { Name = "Hulk" });
            team.AddPlayer(new Player() { Name = "IronMan" });

            team.StartWithPlayer(team.GetPlayer("Hulk"));         
        }
    }
}
