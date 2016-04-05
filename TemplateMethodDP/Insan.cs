using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDP
{
    public class Insan : Canli
    {
        protected override void Dogar()
        {
            Console.WriteLine("İnsan doğar");
        }

        protected override void Yasar()
        {
            Console.WriteLine("İnsan yaşar");
        }

        protected override void Olur()
        {
            Console.WriteLine("İnsan ölür");
        }
    }
}
