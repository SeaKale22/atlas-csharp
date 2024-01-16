using System;
using System.Collections.Generic;

/// <summary> object class </summary>
class Obj
{
    /// <summary> determins if the obj is a class that inherits from specified class </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}