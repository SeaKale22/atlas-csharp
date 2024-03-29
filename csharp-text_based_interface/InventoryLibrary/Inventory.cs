using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// represents an inventory
    /// </summary>
    public class Inventory : BaseClass
    {
        public string user_id;
        public string item_id;
        public int quantity;

        /// <summary> Invetory constructor </summary>
        public Inventory(User user, Item item, int quantity = 1)
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
            if (user == null)
                {
                    throw new ArgumentNullException(nameof(user), "User is required");
                }
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item is required");
            }
            this.user_id = user.id;
            this.item_id = item.id;
            if (quantity <= 0)
            {
                throw new Exception("Quantity must be greater than 0.");
            }
            this.quantity = quantity;
            
        }

    }
}
