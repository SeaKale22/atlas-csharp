using System;

/// <summary>
/// for modifications
/// </summary>
public enum Modifier
{
    /// <summary> weak mod </summary>
    Weak,
    /// <summary> base mod </summary>
    Base,
    /// <summary> strong mod </summary>
    Strong
}

/// <summary>
///  methods that can use the modifiers for calculations
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
