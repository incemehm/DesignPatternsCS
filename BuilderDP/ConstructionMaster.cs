namespace BuilderDP
{
    public abstract class ConstructionMaster
    {
        protected House house;

        public House House
        {
            get { return house; }
        }

        public abstract void setColor();

        public abstract void setArea();

        public abstract void setNumberOfRooms();
    }
}
