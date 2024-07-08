class Program
{
    static void findd(bool r, bool b)
    {
        if(r || b)
        {
            Console.WriteLine("Red or big");
        }
        else
        {
            Console.WriteLine("Not red and not big");
        }
    }

    static void Main(string[] args)
    {
        bool is_red = true;
        bool is_big = true;
        findd(is_red,is_big);

        is_red = false;
        is_big = true;
        findd(is_red,is_big);

        is_red = false;
        is_big = false;
        findd(is_red,is_big);
    }
}

