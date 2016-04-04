using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDP
{
    public abstract class DataEngine
    {
        protected IDBConnection dbConnection;
        public DataEngine(IDBConnection dbConn)
        {
            dbConnection = dbConn;
        }
        
        public IDBConnection DBConnection
        {
            set { dbConnection = value; }
        }

        public abstract void Execute(string sql);
        public abstract void Open(string connStr);
    }
}
