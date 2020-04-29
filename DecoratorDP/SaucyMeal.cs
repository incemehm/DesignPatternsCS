namespace DecoratorDP
{
    public class SaucyMeal : MealDecorator
    {
        public SaucyMeal(IMeal meal) : base(meal)
        {

        }

        public override void Serve()
        {
            System.Console.WriteLine("Saucy meal is being served...");

            // Do some stuff

            base.Serve();
        }
    }
}
