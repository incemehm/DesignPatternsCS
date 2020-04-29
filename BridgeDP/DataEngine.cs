namespace BridgeDP
{
    public class DataEngine
    {
        protected IDBConnection dbConnection;

        public DataEngine(IDBConnection dbConn)
        {
            dbConnection = dbConn;
        }
        
        public virtual void Execute(string query)
        {
            dbConnection.ExecuteQuery(query);
        }
        public virtual void Open(string connStr)
        {
            dbConnection.OpenConnection(connStr);
        }
    }
}
