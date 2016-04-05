using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    public class KisiIterator : IKisiIterator
    {
        private Rehber rehber;
        private int index = 0;

        public KisiIterator(Rehber rehber)
        {
            this.rehber = rehber;
        }

        public Kisi Next()
        {
            index++;
            if (HasItem)
                return rehber.GetItem(index);
            else
                return null;
        }

        public bool HasItem
        {
            get
            {
                return index < rehber.KisiSayisi;
            }
        }

        public Kisi Current
        {
            get
            {
                return rehber.GetItem(index);
            }
        }
    }
}
