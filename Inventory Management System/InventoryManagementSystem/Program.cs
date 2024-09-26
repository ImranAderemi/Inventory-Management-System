using System;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory(); //Declares a variable named inventory, of type 'Inventory'.

        bool Running = true; //If Running is equal to true, then the program is running
        while (Running) //If running is equal to true then the IMS will show up
        {
            Console.WriteLine("\nIMS (Inventory Management System)");
            Console.WriteLine("1. Add an Item");
            Console.WriteLine("2. Update an Item");
            Console.WriteLine("3. View All Items");
            Console.WriteLine("4. Search Items");
            Console.WriteLine("5. Sort Items by Name");
            Console.WriteLine("6. Sort Items by Price");
            Console.WriteLine("7. Exit the IMS");
            
            Console.Write("\r\nSelect an option: ");
            var choice = Console.ReadLine(); //Reads the option that the user inputs and assigns it to "choice"

            switch (choice)
            {            
                case "1": //If choice is equal to 1, then they wish to add a new item to the inventory
                    AddNewItem(inventory); 
                    break;
                case "2": //If choice is equal to 2, then they wish to update an item in the inventory
                    UpdateExistingItem(inventory);
                    break;
                case "3": //If choice is equal to 3, then they wish to view all of the items in the inventory
                    inventory.ViewItems();
                    break;
                case "4": //If choice is equal to 4, then they wish to search for items in the inventory
                    SearchItems(inventory);
                    break;
                case "5": //If choice is equal to 5, then they wish to sort items in the inventory by name
                    inventory.SortByName();
                    break;
                case "6": //If choice is equal to 6, then they wish to sort items in the inventory by price
                    inventory.SortByPrice();
                    break;
                case "7": //If choice is equal to 7, then they wish to close the IMS
                    Running = false;
                    break;

                default: //If nothing is entered, or the data type is invalid or out of range then the user will be prompted to re-enter their choice
                    Console.WriteLine("\r\nThat's an Invalid Option. Please try again, But select an option from 1-7");
                    break;
            }
        }
    }

    static void AddNewItem(Inventory inventory)
    {
        Console.Write("\r\nEnter the Item ID: ");
        int id = int.Parse(Console.ReadLine()); //Stores the item Id that the user enters and assigns it to the value "id"

        Console.Write("Enter the Item Name: ");
        string name = Console.ReadLine(); //Stores the item name that the user enters and assigns it to the value "name"

        Console.Write("Enter the Items' Price: £");
        decimal price = decimal.Parse(Console.ReadLine()); //Stores the item price that the user enters and assigns it to the value "price"

        Console.Write("Enter the Quantity: ");
        int quantity = int.Parse(Console.ReadLine()); //Stores the quanitity that the user enters and assigns it to the value "quantity"

        Item newItem = new Item(id, name, price, quantity); //combines the items id, name, price and quantity and assigns them all to "newItem"
        
        inventory.AddItem(newItem);
    }

    static void UpdateExistingItem(Inventory inventory)
    {
        Console.Write("\r\nEnter the Item ID to Update: ");
        int id = int.Parse(Console.ReadLine()); //the integer that the user enters is later used to identify the item in the inventory

        Console.Write("Enter the New Item Name: ");
        string name = Console.ReadLine(); //Allows the user to enter the new name that they wish to update the current item to

        Console.Write("Enter the New Item Price: £");
        decimal price = decimal.Parse(Console.ReadLine()); //Allows the user to set the new price for the item

        Console.Write("Enter the New Item Quantity: ");
        int quantity = int.Parse(Console.ReadLine()); //Allows the user to update the quantity

        inventory.UpdateItem(id, name, price, quantity);
    }

    static void SearchItems(Inventory inventory)
    {
        Console.Write("\r\nEnter the Item Name to Search: "); //Allows the user to enter the name of the item that they wish to search for
        string name = Console.ReadLine();

        inventory.SearchItems(name);
    }
}

