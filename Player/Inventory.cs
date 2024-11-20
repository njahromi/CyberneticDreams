public class Inventory
{
    private List<Item> items;
    private int maxCapacity;

    public Inventory(int maxCapacity)
    {
        items = new List<Item>();
        this.maxCapacity = maxCapacity;
    }

    public void AddItem(Item item)
    {
        if (items.Count < maxCapacity)
        {
            items.Add(item);
            Console.WriteLine($"Added {item.Name} to inventory.");
        }
        else
        {
            Console.WriteLine("Inventory is full.");
        }
    }

    public void RemoveItem(string itemName)
    {
        Item itemToRemove = items.FirstOrDefault(i => i.Name == itemName);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
            Console.WriteLine($"Removed {itemName} from inventory.");
        }
        else
        {
            Console.WriteLine("Item not found in inventory.");
        }
    }

    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (Item item in items)
        {
            Console.WriteLine("- " + item.Name);
        }
    }
}