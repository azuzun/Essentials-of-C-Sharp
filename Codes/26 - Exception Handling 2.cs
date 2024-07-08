class Program
{
    static void Main(string[] args)
    {
        try
        {
        Console.Write("Enter num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter num2: ");
        int num2 =Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 / num2);
        }

        catch
        {
            Console.WriteLine("Error");
        }
    }
}
