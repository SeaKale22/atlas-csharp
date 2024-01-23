using System;

/// <summary> Matrix Math </summary>
class MatrixMath
{
    /// <summary> finds determinate of matrix </summary>
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            return -1;
        }

        double result = -1;

        if (rows == 2)
        {
            result = matrix[0,0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        else if (rows == 3)
        {
            double a = matrix[0, 0], b = matrix[0, 1], c = matrix[0, 2];
            double d = matrix[1, 0], e = matrix[1, 1], f = matrix[1, 2];
            double g = matrix[2, 0], h = matrix[2, 1], i = matrix[2, 2];
            result = a * (e * i - f * h) - b * (d * i - f * g) + c * (d * h - e * g);
        }

        return Math.Round(result, 2);
    }
}