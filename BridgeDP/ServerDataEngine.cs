using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    public class ServerDataEngine : DataEngine
    {
        public ServerDataEngine(IDBConnection dbConn)
            : base(dbConn)
        {
        }

        public override void Execute(string sql)
        {
            Console.WriteLine("Serverda komut çalıştırılıyor...");
            dbConnection.ExecuteSQL(sql);
        }

        public override void Open(string connStr)
        {
            Console.WriteLine("Servera bağlanılıyor...");
            dbConnection.OpenConnection(connStr);
        }
    }
}
