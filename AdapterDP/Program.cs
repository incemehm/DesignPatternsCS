namespace AdapterDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket();
            socket.Connect();

            EnglishSocket englishSocket = new EnglishSocket();

            socket = new SocketAdapter(englishSocket);
            socket.Connect();
        }
    }
}
