using System;
using System.Reflection;
using System.Collections.Generic;

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
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
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

/// <summary> represents a key </summary>
class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    ///<summary> Key constructor </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary> Collect method </summary>
    public void Collect()
    {
        if (!this.isCollected)
        {
            this.isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else if (this.isCollected)
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }
}

/// <summary>
/// generic collection
/// </summary>
class Objs<T> : IEnumerable<T>
{
    public List<T> objects = new List<T>();

    public void Add(T obj)
    {
        this.objects.Add(obj);
    }

    ///<summary> Implement getenumerator </summary>
    public IEnumerator<T> GetEnumerator()
    {
        return this.objects.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}