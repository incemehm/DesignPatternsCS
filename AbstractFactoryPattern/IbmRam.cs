﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class IbmRam : IRam
    {
        public void IntegrateRAM()
        {
            Console.WriteLine("IBM RAM entegre ediliyor...");
        }
    }
}
