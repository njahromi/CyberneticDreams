public class RandomEncounter
{
    private static Random random = new Random();

    public static void Encounter(Player player)
    {
        int encounterChance = random.Next(100);

        if (encounterChance < 30)
        {
            // Random encounter occurs
            Enemy enemy = GenerateRandomEnemy();
            Console.WriteLine("A wild {0} appears!", enemy.Name);
            CombatSystem.StartCombat(player, enemy);
        }
    }

    private static Enemy GenerateRandomEnemy()
    {
        // Implement logic to generate random enemy types with different stats
        // For example, you could use a weighted random selection based on difficulty level
        // or specific locations.

        // Example:
        int enemyType = random.Next(3);
        switch (enemyType)
        {
            case 0:
                return new Goblin();
            case 1:
                return new Orc();
            case 2:
                return new Dragon();
            default:
                return new Goblin();
        }
    }
}