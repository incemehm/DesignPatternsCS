namespace AdapterDP
{
    public class SocketAdapter : Socket
    {
        private EnglishSocket adapted;
        
        public SocketAdapter(EnglishSocket socket)
        {
            this.adapted = socket;
        }

        public override void Connect()
        {
            adapted.Connect3Pin();
        } 
    }
}
