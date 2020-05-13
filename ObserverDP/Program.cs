namespace ObserverDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification notification = new Notification();

            notification.AddFollower(new TwitterFollower());
            notification.AddFollower(new TwitterFollower());
            notification.AddFollower(new BlogFollower());

            notification.TweetSomething("First tweet!");
        }
    }
}
