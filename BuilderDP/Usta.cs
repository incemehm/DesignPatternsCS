using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public abstract class Usta
    {
        protected Kebap kebap;

        public void CreateKebap()
        {
            kebap = new Kebap();
        }

        public Kebap GetKebap()
        {
            return kebap;
        }

        public abstract void SetKebapProperties();
    }
}
