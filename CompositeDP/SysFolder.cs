using System.Collections.Generic;

namespace CompositeDP
{
    public class SysFolder : IFile
    {
        private List<IFile>  files  = new List<IFile>();

        public void GetName()
        {
            foreach (IFile file in files)
            {
                file.GetName();
            }
        }

        public void AddFile(IFile file)
        {
            files.Add(file);
        }
        public void RemoveFile(IFile file)
        {
            files.Remove(file);
        }

    }
}
