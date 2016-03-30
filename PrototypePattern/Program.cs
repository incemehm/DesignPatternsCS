using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dvd dvd = new Dvd("Düğün DVDsi", "Sample string content");

            Dvd copyDvd = (Dvd)dvd.Clone();

            Console.WriteLine(copyDvd);

        }
    }
}
