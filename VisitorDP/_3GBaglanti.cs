using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDP
{
    public class _3GBaglanti : IBaglanti
    {
        public void Gec(Telefon telefon)
        {
            if (telefon is Samsung)
                Console.WriteLine("Samsung 3G baglantiya gecti.");
            else if (telefon is Sony)
                Console.WriteLine("Sony 3G baglantiya gecti."); 
        }
    }
}
