namespace DecoratorDP
{
    public class SaltyMeal : MealDecorator
    {
        public SaltyMeal(IMeal meal) : base(meal)
        {

        }

        public override void Serve()
        {
            System.Console.WriteLine("Salty meal is being served...");
            
            // Do some stuff

            base.Serve();
        }
    }
}
