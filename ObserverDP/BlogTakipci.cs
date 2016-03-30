using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public class BlogTakipci : ITakipci
    {
        public void Bildir(string tweet)
        {
            Console.WriteLine("Blog takipçisine tweet iletildi.");
        }
    }
}
