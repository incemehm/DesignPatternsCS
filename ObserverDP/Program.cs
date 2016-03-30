using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bildirim bildirim = new Bildirim();

            bildirim.TakipciEkle(new TwitterTakipci());
            bildirim.TakipciEkle(new TwitterTakipci());
            bildirim.TakipciEkle(new BlogTakipci());

            bildirim.TweetAt("İlk tweet!");
        }
    }
}
