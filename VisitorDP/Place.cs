namespace VisitorDP
{
    public abstract class Place
    {
        public abstract void Accept(IVisitor visitor);  
    }
}
