namespace CommandDP
{
    public class RemoteControl
    {
        private ICommand forwardCommand;
        private ICommand backCommand;
        private ICommand rightCommand;
        private ICommand leftCommand;

        public RemoteControl(ICommand forwardCommand, ICommand backCommand, ICommand rightCommand, ICommand leftCommand)
        {
            this.forwardCommand = forwardCommand;
            this.backCommand = backCommand;
            this.rightCommand = rightCommand;
            this.leftCommand = leftCommand;
        }

        public void MoveForward(int unit)
        {
            forwardCommand.Move(unit);
        }

        public void MoveBack(int unit)
        {
            backCommand.Move(unit);
        }

        public void MoveRight(int unit)
        {
            rightCommand.Move(unit);
        }

        public void MoveLeft(int unit)
        {
            leftCommand.Move(unit);
        }
    }
}
