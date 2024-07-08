class Program
{
    static int findMax(int a, int b)
    {
        if(a>b)
        return a;

        else
        return b;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter 2 num to find biggest: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');
        int num1 = Convert.ToInt32(parts[0]);
        int num2 = Convert.ToInt32(parts[1]);

        Console.Write( findMax(num1,num2) + " is bigger" );
    }
}

