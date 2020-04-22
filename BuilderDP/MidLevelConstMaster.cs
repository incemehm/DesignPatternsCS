namespace BuilderDP
{
    public class MidLevelConstMaster : ConstructionMaster
    {
        public MidLevelConstMaster()
        {
            house = new House { ConstructionMasterName = "MidLevelConstMaster" };
        }

        public override void setArea()
        {
            house.Area = 80;
        }

        public override void setColor()
        {
            house.Color = "Gray";
        }

        public override void setNumberOfRooms()
        {
            house.NumberOfRooms = 3;
        }
    }
}
