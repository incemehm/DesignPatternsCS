namespace BridgeDP
{
    public class SQLConnection : IDBConnection
    {
        public void ExecuteQuery(string query)
        {
            System.Console.WriteLine(query + ", command executed in MS-SQL DB...");
        }

        public void OpenConnection(string connStr)
        {
            System.Console.WriteLine(connStr + ", connected to MS-SQL DB...");
        }
    }
}
