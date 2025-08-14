namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Harry Potter", "J.K. Rowling");
            b.DisplayDetails();
            Book e = new EBook("Hunger Games", "Somebody", 69, "EPUB");
            e.DisplayDetails();
        }
    }
}
