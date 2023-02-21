using System;
using System.Runtime.CompilerServices;

namespace PokeBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Professor Oak's Lab.");
            Console.WriteLine("My name is Britnie and I am Professor Oak's assistant.");
            Console.WriteLine("Here you can choose your beginner Pokemon and practice battling!");
            Console.WriteLine("Press 1 for Bulbasaur. Press 2 for Charmander. Press 3 for Squirtle. Press 4 for Pikachu.");
            Console.WriteLine("Type exit to end the game.");
            string userInput = Console.ReadLine();

            // Pokemon are listed with all stats and abilities.
            while (userInput.ToLower() != "exit")
            {
                var playerPokemon;
                var opponentPokemon;
                switch (userInput)
                {
                    case "1":
                
                    Ability Growl = new Ability("Growl", 0, 100, "Growl lowers the target's Attack by one stage.");
                    Ability Tackle = new Ability("Tackle", 40, 100, "Tackle is one of the most common and basic moves a Pokémon learns. It deals damage with no additional effects.");
                    Ability VineWhip = new Ability("Vine Whip", 45, 100, "Vine Whip deals damage with no additional effect.");
                    Pokemon bulbasaur = new Pokemon("Bulbasaur", 001, "Grass", "Seed Pokemon", 45, 49, 49, 45, Growl, Tackle, VineWhip);
                    bulbasaur.DisplayPokemon();
                        playerPokemon= bulbasaur;
                        opponentPokemon = charmander;
                            break;
                

                    case "2":
                
                    Ability Growl = new Ability("Growl", 0, 100, "Growl lowers the target's Attack by one stage.");
                    Ability Scratch = new Ability("Scratch", 40, 100, "Scratch is one of the most common and basic moves a Pokémon learns. It deals damage with no additional effects.");
                    Ability Ember = new Ability("Scratch", 40, 100, "Ember deals damage and has a 10% chance of burning the target.");
                    Pokemon charmander = new Pokemon("Charmander", 004, "Fire", "Lizard Pokemon", 39, 52, 43, 65, Growl, Scratch, Ember); ;
                    charmander.DisplayPokemon();
                        playerPokemon= charmander;
                        opponentPokemon = squirtle;
                            break;

                
                    case "3":
                
                    Ability Tackle = new Ability("Tackle", 40, 100, "Tackle is one of the most common and basic moves a Pokémon learns. It deals damage with no additional effects.");
                    Ability TailWhip = new Ability("Tail Whip", 0, 100, "Tail Whip lowers the target's Defense by one stage.");
                    Ability WaterGun = new Ability("Water Gun", 40, 100, "Water Gun deals damage with no additional effect.");
                    Pokemon squirtle = new Pokemon("Squirtle", 007, "Water", "Tiny Turtle Pokemon", 44, 48, 65, 43, Tackle, TailWhip, WaterGun);
                    squirtle.DisplayPokemon();
                        playerPokemon= squirtle;
                        opponentPokemon = pikachu;
                    
                            break;

                
                    case "4":
                
                    Ability ThunderShock = new Ability("Thunder Shock", 40, 100, "Thunder Shock deals damage and has a 10% chance of paralyzing the target.");
                    Ability Growl = new Ability("Growl", 0, 100, "Growl lowers the target's Attack by one stage.");
                    Ability QuickAttack = new Ability("Quick Attack", 40, 100, "Quick Attack deals damage and has a priority of +1.");
                    Pokemon pikachu = new Pokemon("Pikachu", 0025, "Electric", "Mouse Pokemon", 35, 55, 40, 90, ThunderShock, Growl, QuickAttack);
                    pikachu.DisplayPokemon();
                        playerPokemon= pikachu;
                        opponentPokemon = bulbasaur;
                            break;

                    default:

                        Console.WriteLine("Invalid response. Please select a Pokemon using 1-4.")
                            break;

                }

                Console.WriteLine("Do you wish to continue with your Pokemon?");
                Console.WriteLine("Type Y to continue or N to choose another Pokemon");
                userInput = Console.ReadLine();
                
                // Here we can go to the Pokemon Battle or Choose another Pokemon.
                if(userInput == "Y")
                {
                    Console.WriteLine("Congratulations on choosing your very first Pokemon!");
                    Console.WriteLine("Let's do a practice battle!");
                    Battle.startBattle(playerPokemon, opponentPokemon);

                }
                else if(userInput == "N")
                {
                    Console.WriteLine("No problem! Let's choose another Pokemon!");
                    Console.WriteLine("Press 1 for Bulbasaur. Press 2 for Charmander. Press 3 for Squirtle. Press 4 for Pikachu.");
                    Console.WriteLine("Type exit to end the game.");
                    userInput = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Invalid response. Please choose Y to continue or N to select another Pokemon.");
                }

            }
        }
    }
}