using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rehber rehber = new Rehber();
            rehber.Ekle(new Kisi() { Ad = "mehmet", Numara = 3 });
            rehber.Ekle(new Kisi() { Ad = "ahmet", Numara = 5 });
            rehber.Ekle(new Kisi() { Ad = "murat", Numara = 7 });
            rehber.Ekle(new Kisi() { Ad = "aykut", Numara = 9 });


            IKisiIterator iterator = rehber.GetIterator();
            while (iterator.HasItem)
            {
                Console.WriteLine("{0}:{1}", iterator.Current.Ad, iterator.Current.Numara);
                iterator.Next();
            }
        }
    }
}
