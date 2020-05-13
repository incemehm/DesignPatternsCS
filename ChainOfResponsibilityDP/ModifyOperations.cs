namespace ChainOfResponsibilityDP
{
    public class RemoveSpaceOperation : Operation
    {
        protected override string DoProcess(string word)
        {
            System.Console.WriteLine($"RemoveSpaceOperation before {word}");

            string result = word.Replace(" ", "");

            System.Console.WriteLine($"RemoveSpaceOperation after {result}");

            return result;
        }
    }

    public class InsertDashOperation : Operation
    {
        protected override string DoProcess(string word)
        {
            System.Console.WriteLine($"InsertDashOperation before {word}");

            string result = word.Insert(0, " - ");

            System.Console.WriteLine($"InsertDashOperation after {result}");

            return result;
        }
    }
}
