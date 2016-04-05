using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Takim takim = new Takim { Form = "GGBMGG", Puan = 0 };

            List<ISonuc> sonuclar = new List<ISonuc>();

            foreach (char c in takim.Form.ToCharArray())
            {
                switch (c)
                {
                    case 'G':
                        sonuclar.Add(new Galibiyet());
                        break;
                    case 'B':
                        sonuclar.Add(new Beraberlik());
                        break;
                    case 'M':
                        sonuclar.Add(new Maglubiyet());
                        break;
                    default:
                        break;
                }
            }

            foreach (ISonuc sonuc in sonuclar)
            {
                sonuc.PuanHesapla(takim);
            }

            Console.WriteLine("Form Durumu:" + takim.Form + ", Puan: " + takim.Puan);
        
        }
    }
}
