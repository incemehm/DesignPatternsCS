namespace ChainOfResponsibilityDP
{
    public class LowercaseOperation : Operation
    {
        protected override string DoProcess(string word)
        {
            System.Console.WriteLine($"LowercaseOperation before {word}");

            string result = word.ToLower();

            System.Console.WriteLine($"LowercaseOperation after {result}");

            return result;
        }
    }

    public class UppercaseOperation : Operation
    {
        protected override string DoProcess(string word)
        {
            System.Console.WriteLine($"UppercaseOperation before {word}");

            string result = word.ToUpper();

            System.Console.WriteLine($"UppercaseOperation after {result}");

            return result;
        }
    }
}
