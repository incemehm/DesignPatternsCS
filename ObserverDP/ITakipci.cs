using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDP
{
    public interface ITakipci
    {
        void Bildir(string tweet);
    }
}
