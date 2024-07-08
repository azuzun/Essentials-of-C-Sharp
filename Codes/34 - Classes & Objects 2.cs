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

        Book b2 = new Book();
        b2.title = "John";
        b2.pages = 300;

        Console.WriteLine(b1.title);
        Console.WriteLine(b2.title);        
    }
}





