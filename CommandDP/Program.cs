namespace CommandDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            RemoteControl remoteControl = new RemoteControl(
                new ForwardCommand(robot), 
                new BackCommand(robot),
                new RightCommand(robot),
                new LeftCommand(robot));

            System.Console.WriteLine($"Robot coordinates: X => { robot.PositionX }, Y => { robot.PositionY } ");

            remoteControl.MoveForward(5);
            remoteControl.MoveRight(3);
            remoteControl.MoveForward(3);
            remoteControl.MoveLeft(8);
            remoteControl.MoveBack(3);
            remoteControl.MoveRight(2);

            System.Console.WriteLine($"Robot coordinates: X => { robot.PositionX }, Y => { robot.PositionY } ");
        }
    }
}
