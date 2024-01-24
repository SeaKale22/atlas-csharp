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
        public Item(string Name, string Description = "", float Price = 0.00, List<string> Tags = null)
        {
            this.id = Guid.NewGuid().ToString();
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
            if (Name == null)
            {
                throw new ArgumentNullException(nameof(Name),"Name is required.")
            }
            this.name = Name;
            this.description = Description;
            this.price = Math.Round(Price, 2);
            this.tags = tags ?? new List<string>();
        }

    }
}
