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
    /// <summary> method for interacting with the item </summary>
    void Interact();
}


/// <summary>
/// breakalbe interface
/// </summary>
interface IBreakable
{
    /// <summary> represts the item's durability </summary>
    int durability { get; set; }

    /// <summary> method for damaging the item </summary>
    void Break();
}


/// <summary>
/// collectable interace
/// </summary>
interface ICollectable
{
    /// <summary> if the item has been collected or not </summary>
    bool isCollected { get; set; }

    /// <summary> method for collecting item </summary>
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

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    /// <summary> decoration constructor </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary> interact method </summary>
    public void Interact()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There is a key inside.");
        }
        else if (!isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary> break method </summary>
    public void Break()
    {
        this.durability--;
        if (this.durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        else if (this.durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        else if (this.durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}