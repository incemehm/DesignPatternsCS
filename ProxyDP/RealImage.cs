using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDP
{
    public class RealImage : IImage
    {
        public void LoadImage()
        {
            // Load Image From Disc.
            Console.WriteLine("Image is being loaded from disc...");
        }
    }
}
