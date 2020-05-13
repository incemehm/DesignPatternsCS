using System.Collections.Generic;

namespace IteratorDP
{
    public class PhoneBook<T> : IPhoneBook<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public void Add(T item)
        {
            items.Add(item);
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        public Iterator<T> GetIterator()
        {
            return new PersonIterator<T>(this);
        }
    }
}
