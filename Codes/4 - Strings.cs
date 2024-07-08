class Program
{
    static void Main(string[] args)
    {
        //  0123456789
        //  Steve Jobs 123


        // how many characters
        string phrase = "Steve Jobs 123";
        Console.WriteLine(phrase.Length);

        // make uppercase
        Console.WriteLine(phrase.ToUpper());

        // inculde certain character or not
        Console.WriteLine(phrase.Contains("Steve"));

        // first character
        Console.WriteLine(phrase[0]);

        // at which index
        Console.WriteLine(phrase.IndexOf("123"));

        // print part of it
        Console.WriteLine(phrase.Substring(11));
    }
}




