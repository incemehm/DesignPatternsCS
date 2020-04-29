namespace BridgeDP
{
    public interface IDBConnection
    {
        void ExecuteQuery(string query);

        void OpenConnection(string connStr);
    }
}
