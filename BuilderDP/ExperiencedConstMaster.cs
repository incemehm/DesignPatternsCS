namespace BuilderDP
{
    public class ExperiencedConstMaster : ConstructionMaster
    {
        public ExperiencedConstMaster()
        {
            house = new House { ConstructionMasterName = "ExperiencedConstMaster" };
        }

        public override void setArea()
        {
            house.Area = 120;
        }

        public override void setColor()
        {
            house.Color = "White";
        }

        public override void setNumberOfRooms()
        {
            house.NumberOfRooms = 5;
        }
    }
}
