using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class SysFile : IFile
    {
        private string Filename { get; set; }

        public SysFile(string fileName)
        {
            Filename = fileName;
        }

        public void GetName()
        {
            Console.WriteLine("Dosya İsmi: " + Filename);
        } 
    }
}
