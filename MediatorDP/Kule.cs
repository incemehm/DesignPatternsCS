using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP
{
    public class Kule
    {
        private THY thy;
        private Lufthansa lufthansa;


        public void THYLisansVer(THY thy)
        {
            this.thy = thy;
        }

        public void LufthansaLisansVer(Lufthansa lufthansa)
        {
            this.lufthansa = lufthansa;
        }

        public void THYInisIzniVer()
        {
            lufthansa.Beklet();
        }

        public void LufthansaInisIzniVer()
        {
            thy.Beklet();
        }

    }
}
