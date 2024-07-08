using System;

class Program
{
    static void calc(int num, int exp)
    {
        int result = 1;
        for (int i = 0; i < exp; i++)
        {
            result = result * num;
        }

        Console.WriteLine("Result: " + result);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter num and exp: ");

        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        int num = Convert.ToInt32(parts[0]);
        int exp = Convert.ToInt32(parts[1]);

        calc(num, exp);
    }
}
