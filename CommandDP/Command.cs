namespace CommandDP
{
    public class ForwardCommand : ICommand
    {
        private Robot robot;

        public ForwardCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Move(int unit)
        {
            robot.PositionX += unit;
            System.Console.WriteLine("Robot has moved forward " + unit + " unit");
        }
    }

    public class BackCommand : ICommand
    {
        private Robot robot;

        public BackCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Move(int unit)
        {
            robot.PositionX -= unit;
            System.Console.WriteLine("Robot has moved back " + unit + " unit");             
        }
    }

    public class RightCommand : ICommand
    {
        private Robot robot;

        public RightCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Move(int unit)
        {
            robot.PositionY += unit;
            System.Console.WriteLine("Robot has moved right " + unit + " unit");
        }
    }

    public class LeftCommand : ICommand
    {
        private Robot robot;

        public LeftCommand(Robot robot)
        {
            this.robot = robot;
        }

        public void Move(int unit)
        {
            robot.PositionY -= unit;
            System.Console.WriteLine("Robot has moved left " + unit + " unit");
        }
    }
}
