namespace FlyweightDP
{
    public class Grade
    {
        private string letter;

        public Grade(string letter)
        {
            this.letter = letter;
        }

        public void Print()
        {
            switch (letter)
            { 
                case "AA":
                    System.Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 4.00");
                    break;
                case "BA":
                    System.Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 3.50");
                    break;
                case "BB":
                    System.Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 3.00");
                    break;
                case "CB":
                    System.Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 2.50");
                    break;
                case "CC":
                    System.Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 2.00");
                    break;
                case "FF":
                    System.Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 0.00");
                    break;
                default:
                    break;
            }
        }
    }
}
