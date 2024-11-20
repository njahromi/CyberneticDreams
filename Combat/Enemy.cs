public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackDamage { get; set; }

    public bool IsAlive => Health > 0;

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}