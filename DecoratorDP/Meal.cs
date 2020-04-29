namespace DecoratorDP
{
    public class Meal : IMeal
    {
        public Meal()
        {
        }

        public void Serve()
        {
            System.Console.WriteLine("Meal is being served...");
        }        
    }
}
