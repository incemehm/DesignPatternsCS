namespace DecoratorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IMeal meal = new Meal();
            meal.Serve();

            meal = new SaucyMeal(new Meal());
            meal.Serve();

            meal = new SaltyMeal(new Meal());
            meal.Serve();

            meal = new SaltyMeal(new SaucyMeal(new Meal()));
            meal.Serve();
        }
    }
}
