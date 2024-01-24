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
        public User(string Name)
        {
            this.id = Guid.NewGuid().ToString();
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
            if (Name == null)
            {
                throw new Exception("Name is required")
            }
            this.name = Name;
        }

    }
}
