namespace BuilderDP
{
    public class BeginnerConstMaster : ConstructionMaster
    {
        public BeginnerConstMaster()
        {
            house = new House { ConstructionMasterName = "BeginnerConstMaster" };
        }

        public override void setArea()
        {
            house.Area = 50;
        }

        public override void setColor()
        {
            house.Color = "Smoke";
        }

        public override void setNumberOfRooms()
        {
            house.NumberOfRooms = 1;
        }
    }
}
