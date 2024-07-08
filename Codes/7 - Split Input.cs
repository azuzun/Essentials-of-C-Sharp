// split input

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter num1 oprerand num2: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');
        int num1 = Convert.ToInt32(parts[0]);
        string oprerand = parts[1];
        int num2 = Convert.ToInt32(parts[2]);
        
        Console.WriteLine("Print: " + num1 + oprerand + num2);
    }
}