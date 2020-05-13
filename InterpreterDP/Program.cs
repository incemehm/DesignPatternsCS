using System.Collections.Generic;

namespace InterpreterDP
{
    class Program
    {
        static void Main(string[] args)
        {
            string form = "WWDLDWL";

            List<IResult> results = new List<IResult>();

            foreach (char c in form.ToCharArray())
            {
                switch (c)
                {
                    case 'W':
                        results.Add(new Win());
                        break;
                    case 'D':
                        results.Add(new Draw());
                        break;
                    case 'L':
                        results.Add(new Lost());
                        break;
                    default:
                        break;
                }
            }

            foreach (IResult result in results)            
                result.CalculatePoint();                              
        }
    }
}
