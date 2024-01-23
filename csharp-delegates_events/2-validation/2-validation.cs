using System;

/// <summary> represents a player </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    delegate void CalculateHealth(float amount);

    /// <summary> Player constructor </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp < 1)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
    }

    /// <summary> prits player's health </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary> take damage method </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        float newHp = this.hp - damage;
        this.ValidateHP(newHp);
        Console.WriteLine($"{this.name} takes {damage} damage!");
    }

    /// <summary> heal damage method </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        float newHp = this.hp + heal;
        this.ValidateHP(newHp);
        Console.WriteLine($"{this.name} heals {heal} HP!");
    }

    /// <summary> Sets new hp </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }
}

