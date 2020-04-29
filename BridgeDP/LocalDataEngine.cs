namespace BridgeDP
{
    public class LocalDataEngine : DataEngine
    {
        public LocalDataEngine(IDBConnection dbConn) : base(dbConn)
        {
        }

        public override void Execute(string query)
        {
            System.Console.WriteLine("---- Local Data Engine ----");
            base.Execute(query);
        }

        public override void Open(string connStr)
        {
            System.Console.WriteLine("---- Local Data Engine ----");
            base.Open(connStr);
        }
    }
}
