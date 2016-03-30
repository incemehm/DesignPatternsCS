using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Dvd : IDisc
    {
        public string Name { get; set; }
        public object Content { get; set; }

        public Dvd(string name, object content)
        {
            Name = name;
            Content = content;
        }

        public IDisc Clone()
        {
            return (IDisc)this.MemberwiseClone();
        }
        public override string ToString()
        {
            return "DVD [Name=" + Name + ", Content=" + Content + "]";
        }
    }
}
