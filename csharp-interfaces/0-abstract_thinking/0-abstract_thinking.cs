using System;
using System.Reflection;

/// <summary>
/// Abstract base class
/// </summary>
abstract class Base
{
    /// <summary> name property </summary>
    public string name { get; set;}

    /// <summary> overrides ToString </summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}