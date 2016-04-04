using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDP
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsStatus status = new WindowsStatus() { IsActive = true, Theme = "White" };
            ComputerMemory memory = new ComputerMemory();
            memory.WindowsState = status.Save();

            status.IsActive = false;
            status.Theme = "Black";

            status.Restore(memory.WindowsState);
            Console.WriteLine(status.Theme);

        }
    }
}
