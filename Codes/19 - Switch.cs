using System;

class Program
{
    static string getDay(int a)
    {
        string day = ""; 
        switch (a)
        {
            case 1:
                day = "Monday";
                break;

                day = "Invalid day"; 
                break;
        }
        return day;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter num of the day: ");
        int numDay = Convert.ToInt32(Console.ReadLine());

        string dayName = getDay(numDay);

        Console.WriteLine(numDay + " is " + dayName);
    }
}
