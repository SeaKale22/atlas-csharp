using System;
using System.Collections.Generic;

/// <summary> object class </summary>
class Obj
{
    /// <summary> determins if an object is an int </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}