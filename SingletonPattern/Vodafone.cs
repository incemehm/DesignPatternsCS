using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class Vodafone
    {
        private static Vodafone _line = new Vodafone();
        private const string _name = "VODAFONE";
        private const int _number = 542;

        private Vodafone()
        {
            Console.WriteLine("Vodafone private constructor...");
        }

        public static Vodafone GetInstance()
        {
            return _line;
        }

        public string GetName()
        {
            return _name;
        }
        public int GetNumber()
        {
            return _number;
        }

    }
}
