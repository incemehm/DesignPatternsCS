using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    public class Bildirim : IBildirim
    {
        private List<ITakipci> takipciler = new List<ITakipci>();
        private string tweet = string.Empty;

        public void TakipcilereBildir()
        {
            foreach (ITakipci takipci in takipciler)
                takipci.Bildir(tweet);
        }

        public void TakipciEkle(ITakipci takipci)
        {
            takipciler.Add(takipci);
        }

        public void TweetAt(string tweet)
        {
            this.tweet = tweet;
            TakipcilereBildir();
        }
    }
}
