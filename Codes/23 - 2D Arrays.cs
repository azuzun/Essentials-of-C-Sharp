/*

            {1,2},
            {3,4},
            {5,6}

Row 0: {1, 2}
Row 1: {3, 4}
Row 2: {5, 6}

numberGrid[2,1]

[row, coulmn]

*/

class Program
{
   
    static void Main(string[] args)
    {
        int[,] numberGrid = {
            {1,2},
            {3,4},
            {5,4},
        };
        Console.WriteLine( numberGrid[2,1] );
    }
}
