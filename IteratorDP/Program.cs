namespace IteratorDP
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook<Person> phoneBook = new PhoneBook<Person>();
            phoneBook.Add(new Person() { Name = "fatih", Number = 333 });
            phoneBook.Add(new Person() { Name = "ahmet", Number = 555 });
            phoneBook.Add(new Person() { Name = "murat", Number = 777 });
            phoneBook.Add(new Person() { Name = "aykut", Number = 999 });


            Iterator<Person> iterator = phoneBook.GetIterator();

            while (iterator.MoveNext())
            {
                System.Console.WriteLine("Name: {0}, Number:{1}", iterator.Current.Name, iterator.Current.Number);                
            }
        }
    }
}
