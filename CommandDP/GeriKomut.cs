using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP
{
    public class GeriKomut : IKomut
    {
        private Robot  robot;

        public GeriKomut(Robot robot)
        {
            this.robot = robot;
        }

        public void HareketEt(int birim)
        {
            robot.Position -= birim; 
            Console.WriteLine(birim +" birim geri hareket etti");
             
        }
    }
}
