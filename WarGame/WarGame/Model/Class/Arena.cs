using System;
namespace WarGame
{
    public class Arena : IAttack
    {
        public Arena()
        {
        }

        public Warrior Attack(Warrior player1, Warrior player2)
        {
            Random rnd = new Random();
            int count = 1;
            Console.WriteLine("\nBattle begin!!!");
            while (true)
            {
                Console.WriteLine($"Round {count++}");
                // Player1 attack
                int damageDeal = rnd.Next(player1.EquippedWeapon.DamageMin,
                                          player1.EquippedWeapon.DamageMax + 1);
                player2.DecreaseHP(damageDeal);
                Console.WriteLine($"{player1.Name} attack {player2.Name} " +
                                  $"for {damageDeal} damage.");
                Console.WriteLine($"{player1.Name} HP is {player1.HP}, " +
                                  $"{player2.Name} HP is {player2.HP}");
                // Victory condition
                if (player2.HP <= 0) return player1;

                // Player2 attack
                damageDeal = rnd.Next(player2.EquippedWeapon.DamageMin,
                                      player2.EquippedWeapon.DamageMax + 1);
                player1.DecreaseHP(damageDeal);
                Console.WriteLine($"{player2.Name} attack {player1.Name} " +
                  $"for {damageDeal} damage.");
                Console.WriteLine($"{player1.Name} HP is {player1.HP}, " +
                                  $"{player2.Name} HP is {player2.HP}");
                // Victory condition
                if (player1.HP <= 0) return player2;
            }
        }

    }
}

