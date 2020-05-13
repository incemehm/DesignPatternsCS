namespace VisitorDP
{
    public class StandartVisitor : IVisitor
    {
        public void Visit(Place place)
        {
            if (place is Museum)
                System.Console.WriteLine("Standart Visitor visited Museum and paid 15 euros");
            else if (place is Gallery)
                System.Console.WriteLine("Standart Visitor visited Gallery and paid 25 euros");
        }
    }
}
