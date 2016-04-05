using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    public abstract class Islem
    {
        private Islem siradaki;

        public Islem SonrakiIslem(Islem sonraki)
        {
            siradaki = sonraki;
            return this;
        }

        public void Basla(Makina makina)
        {

            IsYap(makina);

            if (siradaki != null)
            {
                siradaki.Basla(makina);
            }
        }
        protected abstract void IsYap(Makina makina);
    }
}
