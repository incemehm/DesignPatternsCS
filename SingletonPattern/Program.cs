using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Vodafone line = Vodafone.GetInstance();
            string name = line.GetName();
            int number = line.GetNumber();

        }
    }
}
