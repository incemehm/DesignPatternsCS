using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    public interface IKisiIterator
    {
        Kisi Next();
        bool HasItem { get; }
        Kisi Current { get; }
    }
}
