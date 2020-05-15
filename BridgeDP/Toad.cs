namespace BridgeDP
{
    public class Toad : DBClient
    {
        public Toad(IDBConnection dbConn) : base(dbConn)
        {
        }

        public override void Execute(string query)
        {
            System.Console.WriteLine("---- Using Toad by Quest ----");
            dbConnection.ExecuteQuery(query);
        }

        public override void Open(string connStr)
        {
            System.Console.WriteLine("---- Using Toad by Quest ----");
            dbConnection.OpenConnection(connStr);
        }
    }
}
