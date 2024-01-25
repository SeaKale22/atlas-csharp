using System;

/// <summary> represents a player </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    delegate void CalculateHealth(float amount);

    /// <summary> hp event handler </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
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
        Console.WriteLine($"{this.name} takes {damage} damage!");
        this.ValidateHP(newHp);
    }

    /// <summary> heal damage method </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        float newHp = this.hp + heal;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        this.ValidateHP(newHp);
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
        CurrentHPArgs new_hp = new CurrentHPArgs(this.hp);
        OnCheckStatus(new_hp);
    }

    /// <summary> applies a modifier </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return (float)(baseValue * 1.5);
        }
        return baseValue;
    }

    /// <summary> checks status </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
            Console.WriteLine(this.status);
        }
        else if (e.currentHp >= (this.maxHp / 2))
        {
            this.status = $"{this.name} is doing well!";
            Console.WriteLine(this.status);
        }
        else if (e.currentHp >= (this.maxHp * 0.25) && e.currentHp < (this.maxHp / 2))
        {
            this.status = $"{this.name} isn't doing too great...";
            Console.WriteLine(this.status);
        }
        else if (e.currentHp > 0 && e.currentHp < (this.maxHp * 0.25))
        {
            this.status = $"{this.name} needs help!";
            Console.WriteLine(this.status);
        }
        else if (e.currentHp == 0)
        {
            this.status = $"{this.name} is knocked out!";
            Console.WriteLine(this.status);
        }
    }

    /// <summary> hp warning </summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
    }

    /// <summary> checks if hp is less than 25% </summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp <= (this.maxHp * 0.25))
        {
            HPCheck += HPValueWarning;
        }
        HPCheck(this, e);
    }
}
