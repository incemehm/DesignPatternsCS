using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Makina makina = new Makina();
            Islem islem = new SuAlmaIslemi().SonrakiIslem(new YikamaIslemi().SonrakiIslem(new DurulamaIslemi()));

            islem.Basla(makina);

        }
    }
}
