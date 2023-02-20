using System;

namespace PokeBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Professor Oak's Lab.");
            Console.WriteLine("My name is Britnie and I am Professor Oak's assistant.");
            Console.WriteLine("Here you can choose your beginner Pokemon and practice battling!");
            Console.WriteLine("Press 1 for Bulbasaur. Press 2 for Charmandar. Press 3 for Squirtle. Press 4 for Pikachu.");
            Console.WriteLine("Type exit to end the game.");
            string userInput = Console.ReadLine();

            // Pokemon are listed with all stats and abilities.
            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    Pokemon bulbasaur = new Pokemon();
                    bulbasaur.Name = "Bulbasaur";
                    bulbasaur.Id = 001;
                    bulbasaur.Type = "Grass";
                    bulbasaur.Species = "Seed Pokemon";
                    bulbasaur.HP = 45;
                    bulbasaur.Attack = 49;
                    bulbasaur.Defense = 49;
                    bulbasaur.SpecialAttack = 65;
                    bulbasaur.SpecialDefense = 65;
                    bulbasaur.Speed = 45;
                    bulbasaur.Ability1 = "Growl";
                    bulbasaur.Ability2 = "Tackle";
                    bulbasaur.Ability3 = "Vine Whip";
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine($"You have chosen {bulbasaur.Name}!");
                    Console.WriteLine($"{bulbasaur.Type} Type Pokemon.");
                    Console.WriteLine($"{bulbasaur.Name} is a {bulbasaur.Species}.");
                    Console.WriteLine($"Your Pokemon's Health is {bulbasaur.HP}.");
                    Console.WriteLine($"   Attack | {bulbasaur.Attack}");
                    Console.WriteLine($"  Defense | {bulbasaur.Defense}");
                    Console.WriteLine($"    Speed | {bulbasaur.Speed}");
                    Console.WriteLine($"Abilities | {bulbasaur.Ability1}, {bulbasaur.Ability2}, and {bulbasaur.Ability3}");
                    Console.WriteLine("******************************************************************************");


                }
                if (userInput == "2")
                {
                    Pokemon charmandar = new Pokemon();
                    charmandar.Name = "Charmandar";
                    charmandar.Id = 004;
                    charmandar.Type = "Fire";
                    charmandar.Species = "Lizard Pokemon";
                    charmandar.HP = 39;
                    charmandar.Attack = 52;
                    charmandar.Defense = 43;
                    charmandar.SpecialAttack = 60;
                    charmandar.SpecialDefense = 50;
                    charmandar.Speed = 65;
                    charmandar.Ability1 = "Growl";
                    charmandar.Ability2 = "Scratch";
                    charmandar.Ability3 = "Ember"; 
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine($"You have chosen {charmandar.Name}!");
                    Console.WriteLine($"{charmandar.Type} Type Pokemon.");
                    Console.WriteLine($"{charmandar.Name} is a {charmandar.Species}.");
                    Console.WriteLine($"Your Pokemon's Health is {charmandar.HP}.");
                    Console.WriteLine($"   Attack | {charmandar.Attack}");
                    Console.WriteLine($"  Defense | {charmandar.Defense}");
                    Console.WriteLine($"    Speed | {charmandar.Speed}");
                    Console.WriteLine($"Abilities | {charmandar.Ability1}, {charmandar.Ability2}, and {charmandar.Ability3}");
                    Console.WriteLine("******************************************************************************");


                }
                if (userInput == "3")
                {
                    Pokemon squirtle = new Pokemon();
                    squirtle.Name = "Squirtle";
                    squirtle.Id = 007;
                    squirtle.Type = "Water";
                    squirtle.Species = "Tiny Turtle Pokemon";
                    squirtle.HP = 44;
                    squirtle.Attack = 48;
                    squirtle.Defense = 65;
                    squirtle.SpecialAttack = 50;
                    squirtle.SpecialDefense = 64;
                    squirtle.Speed = 43;
                    squirtle.Ability1 = "Tackle";
                    squirtle.Ability2 = "Tail Whip";
                    squirtle.Ability3 = "Water Gun";
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine($"You have chosen {squirtle.Name}!");
                    Console.WriteLine($"{squirtle.Type} Type Pokemon.");
                    Console.WriteLine($"{squirtle.Name} is a {squirtle.Species}.");
                    Console.WriteLine($"Your Pokemon's Health is {squirtle.HP}.");
                    Console.WriteLine($"   Attack | {squirtle.Attack}");
                    Console.WriteLine($"  Defense | {squirtle.Defense}");
                    Console.WriteLine($"    Speed | {squirtle.Speed}");
                    Console.WriteLine($"Abilities | {squirtle.Ability1}, {squirtle.Ability2}, and {squirtle.Ability3}");
                    Console.WriteLine("******************************************************************************");

                }
                if (userInput == "4")
                {
                    Pokemon pikachu = new Pokemon();
                    pikachu.Name = "Pikachu";
                    pikachu.Id = 0025;
                    pikachu.Type = "Electric";
                    pikachu.Species = "Mouse Pokemon";
                    pikachu.HP = 35;
                    pikachu.Attack = 55;
                    pikachu.Defense = 40;
                    pikachu.SpecialAttack = 50;
                    pikachu.SpecialDefense = 50;
                    pikachu.Speed = 90;
                    pikachu.Ability1 = "Growl";
                    pikachu.Ability2 = "Thunder Shock";
                    pikachu.Ability3 = "Quick Attack";
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine($"You have chosen {pikachu.Name}!");
                    Console.WriteLine($"{pikachu.Type} Type Pokemon.");
                    Console.WriteLine($"{pikachu.Name} is a {pikachu.Species}.");
                    Console.WriteLine($"Your Pokemon's Health is {pikachu.HP}.");
                    Console.WriteLine($"   Attack | {pikachu.Attack}");
                    Console.WriteLine($"  Defense | {pikachu.Defense}");
                    Console.WriteLine($"    Speed | {pikachu.Speed}");
                    Console.WriteLine($"Abilities | {pikachu.Ability1}, {pikachu.Ability2}, and {pikachu.Ability3}");
                    Console.WriteLine("******************************************************************************");


                }

                Console.WriteLine("Do you wish to continue with your Pokemon?");
                Console.WriteLine("Type Y to continue or N to choose another Pokemon");
                userInput = Console.ReadLine();
                 // Here we can go to the Pokemon Battle or Choose another Pokemon.
                if (userInput == "Y")
                {
                    Console.WriteLine("Congratulations on choosing your very first Pokemon!");
                    Console.WriteLine("Let's do a practice battle!");
                }
                else if (userInput == "N")
                {
                    Console.WriteLine("No problem! Let's choose another Pokemon!");
                    Console.WriteLine("Press 1 for Bulbasaur. Press 2 for Charmandar. Press 3 for Squirtle. Press 4 for Pikachu.");
                    Console.WriteLine("Type exit to end the game.");
                    userInput = Console.ReadLine();

                }

            }
        }
    }
}