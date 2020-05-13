namespace ChainOfResponsibilityDP
{
    public class PadLeftOperation : Operation
    {
        protected override string DoProcess(string word)
        {
            System.Console.WriteLine($"PadLeftOperation before {word}");

            string result = word.PadLeft(25, '.');

            System.Console.WriteLine($"PadLeftOperation after {result}");

            return result;
        }
    }

    public class PadRightOperation : Operation
    {
        protected override string DoProcess(string word)
        {
            System.Console.WriteLine($"PadRightOperation before {word}");

            string result = word.PadRight(25, '.');

            System.Console.WriteLine($"PadRightOperation after {result}");

            return result;
        }
    }
}
