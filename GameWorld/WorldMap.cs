public class Location
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public List<Enemy> Enemies { get; set; }
    public List<Exit> Exits { get; set; }

    public Location(string name, string description)
    {
        Name = name;
        Description = description;
        Items = new List<Item>();
        Enemies = new List<Enemy>();
        Exits = new List<Exit>();
    }

    public void AddExit(Exit exit)
    {
        Exits.Add(exit);
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void AddEnemy(Enemy enemy)
    {
        Enemies.Add(enemy);
    }
}