using System;

class Program
{
    static void Main(string[] args)
    {
        string password = "abc";
        string entered = "";
        int count = 0;
        int limit = 3;
        bool out_of = false; 

        while(entered != password && out_of == false)
        {
            if(count < limit)
            {
                Console.Write("Enter pass: ");
                entered = Console.ReadLine();
                count++;
            }
            else
            {
                out_of = true;
            }
        }

        if(out_of)
        {
            Console.WriteLine("Out of limit");
        }
        else
        {
            Console.WriteLine("Correct password ");
        }
    }
}
