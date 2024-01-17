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


/// <summary>
/// interactive interface
/// </summary>
interface IInteractive
{
    /// <summary> Not going to be implemented </summary>
    void Interact();
}


/// <summary>
/// breakalbe interface
/// </summary>
interface IBreakable
{
    /// <summary> Not going to be implemented </summary>
    int durability { get; set; }

    /// <summary> Not going to be implemented </summary>
    void Break();
}


/// <summary>
/// collectable interace
/// </summary>
interface ICollectable
{
    /// <summary> Not going to be implemented </summary>
    bool isCollected { get; set; }

    /// <summary> Not going to be implemented </summary>
    void Collect();
}

/// <summary> represents a door </summary>
class Door : Base, IInteractive
{
    /// <summary> Door constructor </summary>
    public Door()
    {
        this.name = "Door";
    }

    /// <summary> Door constructor with optinal param </summary>
    public Door(string Name)
    {
        this.name = Name;
    }
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}