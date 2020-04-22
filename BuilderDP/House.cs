namespace BuilderDP
{
    public class House
    {
        public string ConstructionMasterName { get; set; }
        public string Color { get; set; }
        public int Area { get; set; }
        public int NumberOfRooms { get; set; }

        public override string ToString()
        {
            return "House [ConstructionMasterName=" + ConstructionMasterName + ", Color=" + Color + ", Area=" + Area + ", NumberOfRooms=" + NumberOfRooms + "]";
        }
    }
}
