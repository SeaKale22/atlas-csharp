using System;
using System.Collections.Generic;
using Math;

namespace InventoryLibrary
{
    /// <summary>
    /// represents a user
    /// </summary>
    public class User : BaseClass
    {
        public string name;

        /// <summary> User constructor </summary>
        public User(string name)
        {
            this.id = Guid.NewGuid().ToString();
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name),"Name is required.")
            }
            this.name = name;
        }

    }
}
