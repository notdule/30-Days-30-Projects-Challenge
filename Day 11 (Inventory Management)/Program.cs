using System;
using System.Collections.Generic;

class InventoryItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

class InventoryManager
{
    private List<InventoryItem> inventoryItems = new List<InventoryItem>();

    public void AddItem(InventoryItem item)
    {
        inventoryItems.Add(item);
    }

    public void RemoveItem(int id)
    {
        InventoryItem itemToRemove = inventoryItems.Find(item => item.Id == id);
        if (itemToRemove != null)
        {
            inventoryItems.Remove(itemToRemove);
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    public void DisplayInventory()
    {
        foreach (var item in inventoryItems)
        {
            Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price}");
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManager manager = new InventoryManager();

        InventoryItem item1 = new InventoryItem { Id = 1, Name = "Item 1", Quantity = 10, Price = 50.00 };
        InventoryItem item2 = new InventoryItem { Id = 2, Name = "Item 2", Quantity = 5, Price = 20.00 };

        manager.AddItem(item1);
        manager.AddItem(item2);

        manager.DisplayInventory();

        manager.RemoveItem(2);

        manager.DisplayInventory();
    }
}
