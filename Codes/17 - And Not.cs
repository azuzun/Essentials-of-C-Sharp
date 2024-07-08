class Program
{
    static void findd(bool r, bool b)
    {
        if(r && !b)
        {
            Console.WriteLine("Red and not big");
        }
        else if(r && b)
        {
            Console.WriteLine("Red and big");
        }
    }
    static void Main(string[] args)
    {
        bool is_red = true;
        bool is_big = false;
        findd(is_red,is_big);

        is_red = true;
        is_big = true;
        findd(is_red,is_big);
    }
}

