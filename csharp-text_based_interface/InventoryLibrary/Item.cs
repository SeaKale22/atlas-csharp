using System;
using System.Collections.Generic;

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
        public Item(string name, string description = "", float price = 0.00f, List<string> tags = null)
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name),"Name is required.");
            }
            this.name = name;
            this.description = description;
            this.price = (float)Math.Round(price, 2);
            this.tags = tags ?? new List<string>();
        }

    }
}
