namespace VisitorDP
{
    public class Gallery : Place
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
