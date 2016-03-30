using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    public abstract class MakarnaDecorator : IMakarna
    {
        protected IMakarna makarna;

        public MakarnaDecorator(IMakarna mak)
        {
            this.makarna = mak;
        }

        public abstract void ServisEt();
    }
}

