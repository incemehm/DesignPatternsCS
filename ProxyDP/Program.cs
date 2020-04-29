namespace ProxyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new VirtualImage();
            image.Display();
            image.Display();
        }
    }
}
