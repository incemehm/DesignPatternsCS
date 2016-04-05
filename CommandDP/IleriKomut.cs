using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    public class IleriKomut : IKomut
    {
        private Robot  robot;

        public IleriKomut(Robot robot)
        {
            this.robot = robot;
        }

        public void HareketEt(int birim)
        {
            robot.Position += birim; 
            Console.WriteLine(birim +" birim ileri hareket etti");
             
        }
    }
}
