using System;

/// <summary> Vector Math </summary>
class VectorMath
{
    /// <summary> multiplies a vector by a scalar </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length > 3 || vector.Length < 2)
        {
            double[] invalid_input = new double[] { -1.00 };
            return invalid_input;
        }
        double[] new_vector = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            new_vector[i] = vector[i] * scalar;
        }
        return new_vector;
    }

}