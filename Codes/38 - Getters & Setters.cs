/*
Only G and R can be recorded as rating.

Others considered not rated
*/


class Movie
{
    public string title;
    private string rating;

    public Movie(string aTitle, string aRating)
    {
        title = aTitle;
        adjustRating = aRating;
        
    }

    public string adjustRating
    {
        get
        {
            return rating;
        }
        set
        {
            if(value == "G" || value == "R")
            {
                rating = value;
            }
            else
            {
                rating = "Not rated";
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Movie Iron = new Movie("Iron", "G");
        Movie Mission = new Movie("Mission", "PIG");

        Console.WriteLine(Iron.adjustRating);
        Console.WriteLine(Mission.adjustRating);
    }
}
