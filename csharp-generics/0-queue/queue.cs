using System;

/// <summary>
/// represents a queue
/// </summary>
class Queue<T>
{
    /// <summary> checks the type of queue </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}