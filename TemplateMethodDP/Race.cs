namespace TemplateMethodDP
{
    public abstract class Race
    {
        public void TakeTour()
        {
            Start();
            
            KeepDrive();

            TakeBreak();

            KeepDrive();

            Finish();
        }

        public void Start()
        {
            System.Console.WriteLine("Race starts");
        }

        public void KeepDrive()
        {
            System.Console.WriteLine("Race's going on");
        }

        protected abstract void TakeBreak();
        
        public void Finish()
        {
            System.Console.WriteLine("Race finishes");
        }
    }
}
