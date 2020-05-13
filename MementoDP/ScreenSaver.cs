namespace MementoDP
{
    public class ScreenSaver
    {
        public string Theme { get; set; }
        public int TimeInterval { get; set; }

        public Memento Save()
        {
            return new Memento
            {
                Theme = this.Theme,
                TimeInterval = this.TimeInterval,
            };
        }
        public void Restore(Memento memento)
        {
            this.Theme = memento.Theme;
            this.TimeInterval = memento.TimeInterval;
        }
    }
}
