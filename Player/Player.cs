public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public Inventory Inventory { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
        Attack = 10;
        Defense = 5;
        Inventory = new Inventory(10);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} took {damage} damage. Health: {Health}");
    }
}