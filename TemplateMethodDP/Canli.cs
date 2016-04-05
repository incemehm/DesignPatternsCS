using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDP
{
    public abstract class Canli
    {
        public void HayatDongusu()
        {
            Dogar();
            Yasar();
            Olur();
        }

        protected abstract void Dogar();

        protected abstract void Yasar();

        protected abstract void Olur();
    }
}
