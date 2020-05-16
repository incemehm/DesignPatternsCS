using System.Collections.Generic;

namespace CommandDP
{
    public class RemoteControl
    {
        private List<ICommand> commands;

        public RemoteControl()
        {
            commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (ICommand command in commands)
            {
                command.Move();
            }

            commands.Clear();
        }

    }
}
