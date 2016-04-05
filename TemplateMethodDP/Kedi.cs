using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDP
{
    public class Kedi : Canli
    {
        protected override void Dogar()
        {
            Console.WriteLine("Kedi de doğar");
        }

        protected override void Yasar()
        {
            Console.WriteLine("Kedi de mırlar ve yaşar");
        }

        protected override void Olur()
        {
            Console.WriteLine("Kedi de ölür");
        }
    }
}
