namespace BridgeDP
{
    public abstract class DBClient
    {
        protected IDBConnection dbConnection;

        public DBClient(IDBConnection dbConn)
        {
            dbConnection = dbConn;
        }

        public abstract void Execute(string query);

        public abstract void Open(string connStr);        
    }
}
