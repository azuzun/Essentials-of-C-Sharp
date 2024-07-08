class Program
{
    static int calc(int n, int e)
    {
        if(e == 0)
        {
            return 0;
        }

        else if(e == 1)
        {
            return n;
        }

        else if(e == 2);
        {
            return n * n;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Write a num and its exponent: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');
        int num = Convert.ToInt32( parts[0] );
        int exp = Convert.ToInt32( parts[1] );

        Console.WriteLine("Result: " + calc(num, exp));
    }
}

