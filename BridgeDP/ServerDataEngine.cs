namespace BridgeDP
{
    public class ServerDataEngine : DataEngine
    {
        public ServerDataEngine(IDBConnection dbConn) : base(dbConn)
        {
        }

        public override void Execute(string query)
        {
            System.Console.WriteLine("---- Server Data Engine ----");
            base.Execute(query);
        }

        public override void Open(string connStr)
        {
            System.Console.WriteLine("---- Server Data Engine ----");
            base.Open(connStr);
        }
    }
}
