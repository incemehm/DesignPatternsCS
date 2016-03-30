using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMakarna makarna = new SadeMakarna();
            makarna.ServisEt();

            makarna = new SosluMakarna(new SadeMakarna());
            makarna.ServisEt();

            makarna = new PeynirliMakarna(new SadeMakarna());
            makarna.ServisEt();

            makarna = new PeynirliMakarna(new SosluMakarna(new SadeMakarna()));
            makarna.ServisEt();

        }
    }
}
