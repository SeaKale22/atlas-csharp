using System;
using InventoryLibrary;

namespace InventoryManager
{
    class Program
    {
        static void Main()
        {
            JSONStorage objStorage = new JSONStorage();
            objStorage.Load();

            DisplayPrompt();
            
        }

        public void DisplayPrompt()
        {
            Console.WriteLine("Available Commands:");
            Console.WriteLine("<ClassNames> - Show all ClassNames of objects");
            Console.WriteLine("<All> - Show all objects");
            Console.WriteLine("<All [ClassName]> - Show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> - Create a new object");
            Console.WriteLine("<Show [ClassName object_id]> - Show an object");
            Console.WriteLine("<Update [ClassName object_id]> - Update an object");
            Console.WriteLine("<Delete [ClassName object_id]> - Delete an object");
            Console.WriteLine("<Exit> - Quit the application");
        }
    }
}
