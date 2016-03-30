using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDP
{
    public class NotHavuzu
    {
        private Dictionary<string, Not> notHavuzu = new Dictionary<string, Not>();

        public Not GetNot(string harf)
        {
            if (notHavuzu.ContainsKey(harf))
                return notHavuzu[harf];

            else
            {
                Not not = new Not(harf);

                notHavuzu.Add(harf, not);

                return not;
            }
        
        }

    }
}
