using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int colms = myMatrix.GetLength(1);
        int[,] new_matix = new int[colms, rows];
        for (int i = 0; i < colms; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                new_matix[j, i] = myMatrix[j, i] * myMatrix[j, i];
            }
        }
        return new_matix;
    }
}