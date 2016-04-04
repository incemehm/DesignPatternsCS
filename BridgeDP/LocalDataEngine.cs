using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    public class LocalDataEngine : DataEngine
    {
        public LocalDataEngine(IDBConnection dbConn)
            : base(dbConn)
        {
        }

        public override void Execute(string sql)
        {
            Console.WriteLine("Localhostta komut çalıştırılıyor...");
            dbConnection.ExecuteSQL(sql);
        }

        public override void Open(string connStr)
        {
            Console.WriteLine("Localhosta bağlanılıyor...");
            dbConnection.OpenConnection(connStr);
        }
    }
}
