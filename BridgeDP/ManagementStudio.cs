namespace BridgeDP
{
    public class ManagementStudio : DBClient
    {
        public ManagementStudio(IDBConnection dbConn) : base(dbConn)
        {
        }

        public override void Execute(string query)
        {
            System.Console.WriteLine("---- Using Microsoft SQL Management Studio ----");
            dbConnection.ExecuteQuery(query);
        }

        public override void Open(string connStr)
        {
            System.Console.WriteLine("---- Using Microsoft SQL Management Studio ----");
            dbConnection.OpenConnection(connStr);
        }
    }
}
