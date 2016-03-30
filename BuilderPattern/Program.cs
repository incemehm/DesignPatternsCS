using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Garson garson = new Garson();

            // Adana Kebap istiyoruz, kurulum nesnesini yarat.
            Usta usta = new AdanaUsta();

            // Yönetici sınıfa kurulum nesnesini ver. Adana Kebap ustasını (kurucusunu) seçtik
            garson.SetUstaAndCreateKebap(usta);
            
            // Kebap yapıldı ve hazır
            Kebap kebap = garson.GetKebap();

            Console.WriteLine(kebap);

            // Şimdi de Manisa Kebabı istedik.
            usta = new ManisaUsta();

            garson.SetUstaAndCreateKebap(usta);
            kebap = garson.GetKebap();

            Console.WriteLine(kebap);

        }
    }
}
