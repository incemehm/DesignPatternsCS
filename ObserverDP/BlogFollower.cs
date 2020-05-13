namespace ObserverDP
{
    public class BlogFollower : IFollower
    {
        public void GetNotification(string tweet)
        {
            System.Console.WriteLine($"Blog follower did get new tweet! => {tweet}");
        }
    }
}
