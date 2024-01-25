using System;
using InventoryLibrary;
using System.Collections.Generic;

namespace InventoryManager
{
    class Program
    {

        public static JSONStorage objStorage = new JSONStorage();
        static void Main()
        {
            while (true)
            {
                objStorage.Load();
                DisplayPrompt();
                string userInput = Console.ReadLine();
                ProcessInput(userInput);
            }
            
        }

        public static void DisplayPrompt()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> - Show all ClassNames of objects");
            Console.WriteLine("<All> - Show all objects");
            Console.WriteLine("<All [ClassName]> - Show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> - Create a new object");
            Console.WriteLine("<Show [ClassName object_id]> - Show an object");
            Console.WriteLine("<Update [ClassName object_id]> - Update an object");
            Console.WriteLine("<Delete [ClassName object_id]> - Delete an object");
            Console.WriteLine("<Exit> - Quit the application");
            Console.Write("$$ ");
        }

        public static void ProcessInput(string userInput)
        {
            if (userInput == "ClassNames")
            {
                ClassNames();
            }
            if (userInput == "All")
            {
                All();
            }
            // if (userInput.StartsWith("Create"))
            // {
            //     string[] command = userInput.Split(' ');
            //     if (command.Length != 2)
            //     {
            //         Console.WriteLine("Useage: Create [classname]");
            //     }
            //     else
            //     {
            //         ObjMaker(command[1]);
            //     }
            // }
        }

        public static void ClassNames()
        {
            Console.WriteLine("Class names of objects loaded in storage:");
            foreach (var kvp in objStorage.objects)
            {
                HashSet<string> printedItems = new HashSet<string>();
                string cname = kvp.Value.GetType().Name;
                if (!printedItems.Contains(cname))
                {
                    Console.WriteLine(cname);
                    printedItems.Add(cname);
                }
            }
            Console.WriteLine('\n');
        }

        public static void All()
        {
            Dictionary<string, BaseClass> objects = objStorage.All();
            Console.WriteLine("All objects in storage:");
            foreach (var kvp in objects)
            {
                Console.WriteLine($"{kvp.Value}");
            }
            Console.WriteLine();
        }

        // public static void ObjMaker(string classname);
        // {
        //     switch (classname)
        //     {
        //         case "Item":
        //             Console.Write("Enter the name for the new item: ");
        //             string itemName = Console.ReadLine();
                
        //         default:
        //             Console.WriteLine($"Class '{className}' not recognized or not creatable.");
        //             break;
        //     }
        // }
    }
}
