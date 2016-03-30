using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Priz priz = new Priz();
            priz.Connect();
            Connect(priz);
            //Connect(new IngilizPriz());

            priz = new PrizAdapter();
            priz.Connect();
            Connect(priz);
            Connect(new PrizAdapter());

           // priz = new IngilizPriz();


            Console.ReadKey(); 
        }

        public static void Connect(Priz priz)
        {
            priz.Connect();
        
        }
    }
}
