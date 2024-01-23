using System;

/// <summary> Matrix Math </summary>
class MatrixMath
{
    /// <summary> rotates 2d matrix by given angle in radians </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2 )
        {
            return new double[,] { { -1 } };
        }

        double cosTheta = Math.Cos(angleRadians);
        double sinTheta = Math.Sin(angleRadians)

        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[1, 0];
        double d = matrix[1, 1];

        double aNew = cosTheta * a - sinTheta * b;
        double bNew = sinTheta * a + cosTheta * b;
        double cNew = cosTheta * c - sinTheta * d;
        double dNew = sinTheta * c + cosTheta * d;

        return new double[,] { { aNew, bNew }, { cNew, dNew } };
    }
}