class Book
{
    public string title;
    public int pages;
}

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book();
        b1.title = "Harry";
        b1.pages = 400;

        Console.WriteLine(b1.title + " " + b1.pages);
        
    }
}