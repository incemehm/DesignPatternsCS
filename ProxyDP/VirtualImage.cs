using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDP
{
    public class VirtualImage: IImage
    {
        private IImage image;

        public void LoadImage()
        {
            if (image == null)
            {
                image = new RealImage();
                image.LoadImage();
            }

            Console.WriteLine("Loaded image is being displayed...");

        }
    }
}
