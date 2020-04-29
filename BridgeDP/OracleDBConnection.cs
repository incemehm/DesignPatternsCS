namespace BridgeDP
{
    public class OracleDBConnection : IDBConnection
    {
        public void ExecuteQuery(string query)
        {
            System.Console.WriteLine(query + ", command executed in Oracle DB...");
        }

        public void OpenConnection(string connStr)
        {
            System.Console.WriteLine(connStr + ", connected to Oracle DB...");
        }
    }
}
