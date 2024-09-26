using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private List<Item> _items;

    public Inventory()
    {
        _items = new List<Item>();
    }


    //adding a new item to the inventory
    public void AddItem(Item item)
    {
        _items.Add(item);
        Console.WriteLine("\r\nThe item has been added Successfully!");
    }


    //updating an existing item using its itemId
    public void UpdateItem(int itemId, string itemName, decimal price, int quantity)
    {
        var item = _items.FirstOrDefault(i => i.ItemId == itemId);
        if (item != null)
        {
            item.ItemName = itemName;
            item.Price = price;
            item.Quantity = quantity;
            Console.WriteLine("\r\nThe item has been updated Successfully!");
        }
        else
        {
            Console.WriteLine("\r\nThe item wasn't found.");
        }
    }


    //viewing all items in the inventory
    public void ViewItems()
    {
        if (_items.Count > 0)
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("\r\nThere aren't any items in the inventory.");
        }
    }


    //searching for items using their name
    public void SearchItems(string name)
    {
        var results = _items.Where(i => i.ItemName.ToLower().Contains(name.ToLower())).ToList();
        if (results.Any())
        {
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("\r\nNo items matched this search.");
        }
    }


    //sorting items by name
    public void SortByName()
    {
        var sortedItems = _items.OrderBy(i => i.ItemName).ToList();
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item);
        }
    }


    //sorting items by price
    public void SortByPrice()
    {
        var sortedItems = _items.OrderBy(i => i.Price).ToList();
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item);
        }
    }
}
