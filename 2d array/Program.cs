using System;

namespace _2d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] numberGrid = {{1,2,3},{4,5,6}};//[, ] is a way to saying that you want 2d array
            for(int i = 0; i < numberGrid.GetLength(0); i++)
            {
                for(int j = 0; j < numberGrid.GetLength(i); j++)
                {
                    Console.WriteLine(numberGrid[i,j]);
                }
            }
        }
    }
}
