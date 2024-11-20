public class CombatSystem
{
    public static void StartCombat(Player player, Enemy enemy)
    {
        while (player.IsAlive && enemy.IsAlive)
        {
            // Player's turn
            Console.WriteLine("Your turn:");
            // Display player's actions (attack, defend, use item)
            string playerAction = Console.ReadLine();

            // Process player's action
            switch (playerAction)
            {
                case "attack":
                    enemy.TakeDamage(player.AttackDamage);
                    break;
                // ... other actions ...
            }

            // Enemy's turn
            if (enemy.IsAlive)
            {
                Console.WriteLine("Enemy's turn:");
                player.TakeDamage(enemy.AttackDamage);
            }
        }

        if (player.IsAlive)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}