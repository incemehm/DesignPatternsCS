namespace DecoratorDP
{
    public abstract class MealDecorator : IMeal
    {
        protected IMeal meal;

        public MealDecorator(IMeal meal)
        {
            this.meal = meal;
        }

        public abstract void Serve();
    }
}

