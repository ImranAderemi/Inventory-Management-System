using System;

public class Item //allows the class "item" to be global and accesible from everywhere in the program
{
    public int ItemId { get; set; } //unique id for each item
    public string ItemName { get; set; } //name of the item
    public decimal Price { get; set; } //price of the item
    public int Quantity { get; set; } //item quantity 

    //"get" allows the current value to be retrieved
    //"set" allows the value to be changed


    public Item(int itemId, string itemName, decimal price, int quantity) //data type of each parameter is being set, e.g. price is being set to decimal
    {
        ItemId = itemId;
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }


    public override string ToString() //Where the inventory is output
    {
        return "\r\n ID: " + ItemId + "\r\n Name: " + ItemName + "\r\n Price: £" + Price + "\r\n Quantity: " + Quantity + " units";

    }
}
