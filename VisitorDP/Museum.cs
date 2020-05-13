namespace VisitorDP
{
    public class Museum : Place
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
