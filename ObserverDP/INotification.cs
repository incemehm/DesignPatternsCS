namespace ObserverDP
{
    public interface INotification
    {
        void Notify();
        void AddFollower(IFollower follower);
    }
}
