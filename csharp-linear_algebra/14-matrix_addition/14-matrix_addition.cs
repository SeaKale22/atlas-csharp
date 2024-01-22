using System;

/// <summary> Matrix Math </summary>
class MatrixMath
{
    /// <summary> adds two matrices </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if ((rows1 != 2 && rows1 != 3) || (cols1 != 2 && cols1 != 3) ||
            (rows2 != 2 && rows2 != 3) || (cols2 != 2 && cols2 != 3) ||
            (rows1 != rows2) || (cols1 != cols2))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, cols1];

        for (int i = 0; i < rows1; i++)
        {
            (int j = 0; j < cols1; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }
}