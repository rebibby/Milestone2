using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    class Inventory
    {
        static void Main(string[] args)
        {
            InventoryItem item = new InventoryItem("M Book", "Mystery book", 14, 16.99M, 132);
            Console.WriteLine("An item has been created.");
            Console.WriteLine("Item Name: " + item.Name);
            Console.WriteLine("Description: " + item.Description);
            Console.WriteLine("Quantity: " + item.Quantity);
            Console.WriteLine("Price: " + item.Price);
            Console.WriteLine("Model ID: " + item.ModelID);

            Console.ReadKey();
        }
    }
}
