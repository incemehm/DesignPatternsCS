namespace SingletonDP
{
    sealed class Vodafone
    {
        private static Vodafone _line = new Vodafone();
        private const string _name = "VODAFONE";
        private const int _number = 542;

        private static readonly object lockObj = new object();

        private Vodafone()
        {
            System.Console.WriteLine("Vodafone private constructor...");
        }

        public static Vodafone GetInstance()
        {
            if (_line == null)
            {
                lock (lockObj)
                {
                    if (_line == null)
                    {
                        _line = new Vodafone();
                    }
                }
            }
            return _line;
        }

        public string GetName()
        {
            return _name;
        }
        public int GetNumber()
        {
            return _number;
        }
    }

    sealed class VodafoneLazy
    {
        private const string _name = "VODAFONE LAZY";
        private const int _number = 542;
        
        private VodafoneLazy()
        {
            System.Console.WriteLine("Vodafone lazy private constructor...");
        }

        private static readonly System.Lazy<VodafoneLazy> lazy = new System.Lazy<VodafoneLazy>(() => new VodafoneLazy());
    
        public static VodafoneLazy GetInstance()
        {
            return lazy.Value;
        }

        public string GetName()
        {
            return _name;
        }
        public int GetNumber()
        {
            return _number;
        }
    }
}
