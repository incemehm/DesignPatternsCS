using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            DataEngine engine = new LocalDataEngine(new MsSqlDBConnection());
            engine.Open("connStr");
            engine.Execute("select * from records");

            engine = new LocalDataEngine(new OracleDBConnection());
            engine.Open("connStr");
            engine.Execute("select * from records");

            engine = new ServerDataEngine(new MsSqlDBConnection());
            engine.Open("connStr");
            engine.Execute("select * from records");

            engine = new ServerDataEngine(new OracleDBConnection());
            engine.Open("connStr");
            engine.Execute("select * from records");

        }
    }
}
