namespace ChainOfResponsibilityDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation mainOperation = new LowercaseOperation();
            Operation removeSpaceOperation = mainOperation.SetNextOperation(new RemoveSpaceOperation());
            Operation padLeftOperation = removeSpaceOperation.SetNextOperation(new PadLeftOperation());
            Operation insertDashOperation = padLeftOperation.SetNextOperation(new InsertDashOperation());
            Operation padRightOperation = insertDashOperation.SetNextOperation(new PadRightOperation());

            mainOperation.Start("Hello World!");

            System.Console.WriteLine("-----------------------");

            mainOperation = new InsertDashOperation();
            padRightOperation = mainOperation.SetNextOperation(new PadRightOperation());
            removeSpaceOperation = padRightOperation.SetNextOperation(new RemoveSpaceOperation());
            padLeftOperation = removeSpaceOperation.SetNextOperation(new PadLeftOperation());
            padLeftOperation.SetNextOperation(new UppercaseOperation());

            mainOperation.Start("Hello Mars!");

        }
    }
}
