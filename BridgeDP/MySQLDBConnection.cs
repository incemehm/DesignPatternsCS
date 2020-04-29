namespace BridgeDP
{
    public class MySQLDBConnection : IDBConnection
    {
        public void ExecuteQuery(string query)
        {
            System.Console.WriteLine(query + ", command executed in MySQL DB...");
        }

        public void OpenConnection(string connStr)
        {
            System.Console.WriteLine(connStr + ", connected to MySQL DB...");
        }
    }
}
