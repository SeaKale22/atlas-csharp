using System;

/// <summary> Vector Math </summary>
class VectorMath
{
    /// <summary> adds two vectors </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length > 3 || vector1.Length < 2 || vector2.Length > 3 || vector2.Length < 2)
        {
            double[] invalid_input = new double[] { -1.00 };
            return invalid_input;
        }
        double[] new_vector = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            new_vector[i] = vector1[i] + vector2[i];
        }
        return new_vector;
    }
}