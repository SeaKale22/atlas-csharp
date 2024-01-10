using System;

namespace Enemies
{
    /// <summary>Defines a Zombie</summary>
    public class Zombie
    {
        /// <summary>Represents Zombies Health</summary>
        public int health;

        /// <summary>Zombie Constructor</summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Zombie Constructor with int param</summary>
        public Zombie(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
    }
}