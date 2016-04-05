using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Canli canli = new Insan();
            canli.HayatDongusu();

            canli = new Kedi();
            canli.HayatDongusu();
        }
    }
}
