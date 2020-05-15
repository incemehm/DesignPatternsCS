namespace BridgeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            DBClient client = new ManagementStudio(new SQLConnection());
            client.Open("connStr");
            client.Execute("select * from records");

            client = new ManagementStudio(new OracleConnection());
            client.Open("connStr");
            client.Execute("select * from records");

            client = new Toad(new SQLConnection());
            client.Open("connStr");
            client.Execute("select * from records");

            client = new Toad(new OracleConnection());
            client.Open("connStr");
            client.Execute("select * from records");
        }
    }
}
