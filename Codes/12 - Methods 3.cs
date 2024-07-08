class Program
{
    // void Main(string[] args)         ERROR
    static void Main(string[] args)
    {
        Console.Write("Enter 2 name: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');
        string name1 = parts[0];
        string name2 = parts[1];

        printMethod(name1,name2);
    }

    static void printMethod(string n1, string n2)
    {
        Console.WriteLine("n1: " + n1 + " n2: " + n2);
    }
}

/*

you need to make the sayHi and Main methods static,
because Main is a static method by default
and can only call other static methods.

*/