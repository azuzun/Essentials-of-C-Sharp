class Book
{
    public Book(string name)
    {
        Console.WriteLine("Name: " + name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Harry");
 
    }
}