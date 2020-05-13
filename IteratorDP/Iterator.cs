namespace IteratorDP
{
    public interface Iterator<T>
    {
        bool MoveNext();
        T Current { get; }
    }
}
