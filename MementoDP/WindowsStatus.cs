using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDP
{
    public class WindowsStatus
    {
        public bool IsActive { get; set; }
        public string Theme { get; set; }

        public TempWindowsStatus Save()
        {
            return new TempWindowsStatus
            {
                IsActive = this.IsActive,
                Theme = this.Theme
            };
        }
        public void Restore(TempWindowsStatus status)
        {
            this.IsActive = status.IsActive;
            this.Theme = status.Theme;
        }
    }
}
