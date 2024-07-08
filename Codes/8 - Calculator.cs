
class Program
{
    static void calc(int num1, string op,int num2)
    {
        int result = 0;

        if(op == "+")
        {
            result = num1 + num2;
        }
        else if(op == "-")
        {
            result = num1 - num2;
        }
        Console.WriteLine("Result: " + result);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter num operand num: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');
        int num1 = Convert.ToInt32(parts[0]);
        string operand = parts[1];
        int num2 = Convert.ToInt32(parts[2]);

        calc(num1,operand,num2);
    }
}

/*

Chat GBT EXPLAINATION

string[] parts = input.Split(' ');

takes the input string (which the user entered)
and splits it into an array of substrings
using the space character ' ' as the delimiter.

For example, if the user enters "5 + 3", the input.Split(' ') call
will produce an array parts that contains {"5", "+", "3"}.



int num1 = Convert.ToInt32(parts[0]);

converts the first element of the parts array (which is a string) to an integer.
parts[0] is the first number (e.g., "5"),
and Convert.ToInt32(parts[0]) converts it to an integer 5.
The integer value is stored in the variable num1.



string oprnd = parts[1];

assigns the second element of the parts array (which is the operator) to the variable oprnd.
parts[1] is the operator (e.g., "+"),
and oprnd now holds this value as a string.



int num2 = Convert.ToInt32(parts[2]);

converts the third element of the parts array (which is a string) to an integer.
parts[2] is the second number (e.g., "3"),
and Convert.ToInt32(parts[2]) converts it to an integer 3.
The integer value is stored in the variable num2.


*/
