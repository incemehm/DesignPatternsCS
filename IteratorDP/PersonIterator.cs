namespace IteratorDP
{
    public class PersonIterator<T> : Iterator<T>
    {
        private PhoneBook<T> phoneBook;
        private int index;
        private T current;

        public PersonIterator(PhoneBook<T> phoneBook)
        {
            this.phoneBook = phoneBook;
            this.index = 0;
            this.current = default(T);
        }

        public bool MoveNext()
        {
            if (index < phoneBook.Count)
            {
                current = phoneBook.GetItem(index);
                index++;
                return true;
            }
            else            
                return false;
            
        }

        public T Current
        {
            get
            {
                return current;
            }
        }
    }
}
