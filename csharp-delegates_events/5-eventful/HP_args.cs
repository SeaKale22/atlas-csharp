using System;

/// <summary> current HP args </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary> current hp </summary>
    public float currentHp { get; }

    /// <summary> constructor </summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}