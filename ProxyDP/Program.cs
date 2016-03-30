using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new VirtualImage();
            image.LoadImage();
            image.LoadImage();
        }
    }
}
