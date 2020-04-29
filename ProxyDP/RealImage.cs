namespace ProxyDP
{
    public class RealImage : IImage
    {
        public RealImage()
        {
            // Load Image From Disc.
            System.Console.WriteLine("Image is being loaded from disc...");
        }

        public void Display()
        {
            System.Console.WriteLine("Loaded image is being displayed...");
        }
    }
}
