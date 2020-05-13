namespace VisitorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Museum museum = new Museum();
            Gallery gallery = new Gallery();

            IVisitor studentVisitor = new StudentVisitor();
            IVisitor standartVisitor = new StandartVisitor();

            museum.Accept(studentVisitor);
            gallery.Accept(studentVisitor);

            museum.Accept(standartVisitor);
            gallery.Accept(standartVisitor);
        }
    }
}
