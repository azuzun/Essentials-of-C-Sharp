class Book
{
    public string title;
    public int page;
    public Book(string aTitle, int aPage)
    {
        title = aTitle;
        page = aPage;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Harry", 100);
        Book b2 = new Book("John", 100);

        Console.WriteLine(b1.title);
    }
}