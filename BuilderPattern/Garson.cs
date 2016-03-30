using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP
{
    public class Garson
    {
        private Usta usta;

        public void SetUstaAndCreateKebap(Usta usta)
        {
            this.usta = usta;

            // Kebabı yarat
            this.usta.CreateKebap();

            // Kebabın özelliklerini ata.
            this.usta.SetKebapProperties();
        }

        public Kebap GetKebap()
        {
            return usta.GetKebap();
        }
    }
}
