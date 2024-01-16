using System;
using System.Collections.Generic;

/// <summary> object class </summary>
class Obj
{
    /// <summary> determins if the object is an array or inharits from an array </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}