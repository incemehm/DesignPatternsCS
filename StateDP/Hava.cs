using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDP
{
    public class Hava
    {
        private IHavaDurumu havaDurumu;

        public Hava()
        {
            havaDurumu = new GunesliHava();
        }

        public void Giyin()
        {
            havaDurumu.Giyin();
        }

        public void DurumDegistir(IHavaDurumu havaDurumu)
        {
            this.havaDurumu = havaDurumu;
        }
    }
}
