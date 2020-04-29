namespace ProxyDP
{
    public class VirtualImage: IImage
    {
        private IImage image;

        public void Display()
        {
            if (image == null)
            {
                image = new RealImage();
            }

            image.Display();
        }
    }
}
