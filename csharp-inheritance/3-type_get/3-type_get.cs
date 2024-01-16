using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary> object stuff </summary>
class Obj
{
    /// <summary> prints names of avaliable properties and methods of an object </summary>
    public static void Print(object myObj)
    {
        string typeName = myObj.GetType().Name;
        PropertyInfo[] properties = myObj.GetType().GetProperties();
        MethodInfo[] methods = myObj.GetType().GetMethods();

        Console.WriteLine($"{typeName} Properties:");
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name}");
        }

        Console.WriteLine($"{typeName} Methods:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"{method.Name}");
        }

    }
}