using System;

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
                    Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 4.00");
                    break;
                case "BA":
                    Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 3.50");
                    break;
                case "BB":
                    Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 3.00");
                    break;
                case "CB":
                    Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 2.50");
                    break;
                case "CC":
                    Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 2.00");
                    break;
                case "FF":
                    Console.WriteLine("LETTER GRADE:" + letter + ", in NUMBER: 0.00");
                    break;
                default:
                    break;
            }
        }
    }
}
