using System;

namespace MyMath
{
    /// <summary>
    /// matrix operations
    /// </summary>
    public class Matrix
    {
        /// <summary> divide matrix </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix is null)
            {
                return null;
            }
            int rows = matrix.GetLength(0);
            int colms = matrix.GetLength(1);
            int[,] new_matix = new int[rows, colms];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    try
                    {
                        new_matix[i, j] = matrix[i, j] / num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                }
            }
            return new_matix;
        }
    }
}
