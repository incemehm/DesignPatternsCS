namespace ObserverDP
{
    public class TwitterFollower : IFollower
    {
        public void GetNotification(string tweet)
        {
            System.Console.WriteLine($"Twitter follower did get new tweet! => {tweet}");
        }
    }
}
