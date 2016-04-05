using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Samsung s3 = new Samsung();
            s3.GecisYap(new _3GBaglanti());
            s3.GecisYap(new _4GBaglanti());


            Sony xperia = new Sony();
            xperia.GecisYap(new _3GBaglanti());
            xperia.GecisYap(new _4GBaglanti());

        }
    }
}
