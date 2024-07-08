// Console.ReadLine() -> reads string

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter num1: ");

        // int num = Console.ReadLine();    ERROR
        string num1 = Console.ReadLine();

//-

        Console.Write("Enter num2: ");

        int num2 = Convert.ToInt32( Console.ReadLine() );


        Console.WriteLine("n1: " + num1 + " n2: " + num2);
    }
}


