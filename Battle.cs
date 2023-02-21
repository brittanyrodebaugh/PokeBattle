using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    public class Battle
    {
        public static void startBattle(Pokemon playerPokemon, Pokemon opponentPokemon) 
        
        {
            Console.WriteLine($"You have chosen {playerPokemon.Name} and your opponent is {opponentPokemon.Name}!");
            Console.WriteLine("Let's Begin!");
           while (opponentPokemon.HP > 0 && playerPokemon.HP > 0)
            {

            }
        }

    }
}
