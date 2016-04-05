using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            UzaktanKumanda kumanda = new UzaktanKumanda(new IleriKomut(robot), new GeriKomut(robot));
            kumanda.IleriGit(5);
            kumanda.GeriGit(3);
            kumanda.IleriGit(8);
        }
    }
}
