using System;

/// <summary> Matrix Math </summary>
class MatrixMath
{
    /// <summary> multiplies matrix and scalar </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if ((rows != 2 && rows != 3) || (cols != 2 && cols != 3))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, cols1];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                result[i, j] = matrix1[i, j] * scalar;
            }
        }
        return result;
    }
}