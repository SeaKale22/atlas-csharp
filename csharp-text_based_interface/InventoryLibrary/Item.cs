using System;
using System.Collections.Generic;
using Math;

namespace InventoryLibrary
{
    /// <summary>
    /// represents an item
    /// </summary>
    public class Item : BaseClass
    {
        public string name;
        public string description;
        public float price;

        public List<string> tags;

        /// <summary> Item constructor </summary>
        public Item(string name, string description = "", float price = 0.00, List<string> tags = null)
        {
            this.id = Guid.NewGuid().ToString();
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name),"Name is required.")
            }
            this.name = name;
            this.description = description;
            this.price = Math.Round(price, 2);
            this.tags = tags ?? new List<string>();
        }

    }
}
