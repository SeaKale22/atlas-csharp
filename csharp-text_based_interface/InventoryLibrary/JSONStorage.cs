using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// class for inv storage
    /// </summary>
    public class JSONStorage
    {
        public Dictionary<string, BaseClass> objects { get; private set; }

        ///<summary> Constructor </summary>
        public JSONStorage()
        {
            objects = new Dictionary<string, BaseClass>();
        }

        /// <summary> return objects </summary>
        public Dictionary<string, BaseClass> All()
        {
            return this.objects;
        }

        /// <summary> add new obj to objects </summary>
        public void New(BaseClass obj)
        {
            string key = $"{obj.GetType().Name}.{obj.id}";
            objects[key] = obj;
        }

        public void Save()
        {
            string json = JsonSerializer.Serialize(objects);
            File.WriteAllText("storage/inventory_manager.json", json);
        }
    }
}
