namespace VisitorDP
{
    public class StudentVisitor : IVisitor
    {
        public void Visit(Place place)
        {
            if (place is Museum)
                System.Console.WriteLine("Student Visitor visited Museum and paid 3 euros");
            else if (place is Gallery)
                System.Console.WriteLine("Student Visitor visited Gallery and paid 5 euros");
        }
    }
}
