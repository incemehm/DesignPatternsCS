using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class SysFolder : IFile
    {
        private List<IFile>  fileList  = new List<IFile>();

        public void GetName()
        {
            foreach (IFile file in fileList)
            {
                file.GetName();
            }
        }

        public void AddFile(IFile file)
        {
            fileList.Add(file);
        }
        public void RemoveFile(IFile file)
        {
            fileList.Remove(file);
        }

    }
}
