using System;

/// <summary> Vector Math </summary>
class VectorMath
{
    /// <summary> finds magnitude of a 2d or 3d vector </summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length > 3 || vector.Length < 2)
        {
            return -1;
        }
        double mag = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            mag += Math.Pow(vector[i], 2);
        }
        return Math.Round(Math.Sqrt(mag), 2);
    }

}