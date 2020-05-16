namespace CommandDP
{
    public class ForwardCommand : ICommand
    {
        private Robot robot;

        public ForwardCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Move()
        {
            robot.PositionX += 1;
            System.Console.WriteLine("Robot has moved forward");
        }
    }

    public class BackCommand : ICommand
    {
        private Robot robot;

        public BackCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Move()
        {
            robot.PositionX -= 1;
            System.Console.WriteLine("Robot has moved back");             
        }
    }

    public class RightCommand : ICommand
    {
        private Robot robot;

        public RightCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Move()
        {
            robot.PositionY += 1;
            System.Console.WriteLine("Robot has moved right");
        }
    }

    public class LeftCommand : ICommand
    {
        private Robot robot;

        public LeftCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Move()
        {
            robot.PositionY -= 1;
            System.Console.WriteLine("Robot has moved left");
        }
    }
}
