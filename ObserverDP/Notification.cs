using System.Collections.Generic;

namespace ObserverDP
{
    public class Notification : INotification
    {
        private List<IFollower> followers = new List<IFollower>();
        private string tweet = string.Empty;

        public void Notify()
        {
            foreach (IFollower follower in followers)
                follower.GetNotification(tweet);
        }

        public void AddFollower(IFollower follower)
        {
            followers.Add(follower);
        }

        public void TweetSomething(string content)
        {
            this.tweet = content;
            Notify();
        }
    }
}
