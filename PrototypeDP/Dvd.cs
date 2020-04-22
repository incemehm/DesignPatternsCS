namespace PrototypeDP
{
    public class Dvd : Disc
    {
        public string Name { get; set; }
        public object Content { get; set; }

        public Dvd(string name, object content)
        {
            Name = name;
            Content = content;
        }
        
        public override Disc Clone()
        {
            return (Disc)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "DVD [Name=" + Name + ", Content=" + Content + "]";
        }

    }
}
