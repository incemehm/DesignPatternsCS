using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    public class Rehber : IRehber
    {

        private List<Kisi> kisiler = new List<Kisi>();
        public int KisiSayisi { 
            get { return kisiler.Count; } }

        public void Ekle(Kisi kisi)
        {
            kisiler.Add(kisi);
        }
        public Kisi GetItem(int index)
        {
            return kisiler[index];
        }
        public IKisiIterator GetIterator()
        {
            return new KisiIterator(this);
        }
    }
}
