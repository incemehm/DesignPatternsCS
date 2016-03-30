using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            SysFile file1 = new SysFile("File 1");
            SysFile file2 = new SysFile("File 2");
            SysFile file3 = new SysFile("File 3");
            SysFile file4 = new SysFile("File 4");
            SysFile file5 = new SysFile("File 5");
            SysFile file6 = new SysFile("File 6");

            SysFolder folder1 = new SysFolder();
            SysFolder folder2 = new SysFolder();

            SysFolder folderManager = new SysFolder();

            folder1.AddFile(file1);
            folder1.AddFile(file4);
            folder1.AddFile(file6);

            folder2.AddFile(file2);
            folder2.AddFile(file5);

            folderManager.AddFile(folder1);
            folderManager.AddFile(file3);
            folderManager.AddFile(folder2);

            // Ağaç yapısı üzerinde dolaşarak, tüm dosyaların bilgileri yazılır.
            folderManager.GetName();
        }
    }
}
