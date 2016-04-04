using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    public class MsSqlDBConnection : IDBConnection
    {
        public void ExecuteSQL(string sql)
        {
            Console.WriteLine(sql + " komutu MsSqlde çalıştırıldı...");
        }

        public void OpenConnection(string connStr)
        {
            Console.WriteLine(connStr + " ile MsSqle bağlandı...");
        }
    }
}
