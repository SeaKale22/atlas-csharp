using System;
using System.Collections.Generic;

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
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name),"Name is required.");
            }
            this.name = name;
        }

    }
}
