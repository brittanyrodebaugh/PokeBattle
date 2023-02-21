using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBattle
{
    public class Pokemon
    {
        public string Name;
        public int Id;
        public string Type;
        public string Species;
        public int HP;
        public int Attack;
        public int Defense;
        public int Speed;
        public Ability Ability1;
        public Ability Ability2;
        public Ability Ability3;

        public Pokemon(string Name, int Id, string Type, string Sprecies, int HP, int Attack, int Defense, int Speed, Ability Ability1, Ability Ability2, Ability Ability3)
        {

            this.Name = Name;
            this.Id = Id;
            this.Type = Type;
            this.Species = Sprecies;
            this.HP = HP;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Speed = Speed;
            this.Ability1 = Ability1;
            this.Ability2 = Ability2;
            this.Ability3 = Ability3;
        }

        public void DisplayPokemon ()
        {

            Console.WriteLine("******************************************************************************");
            Console.WriteLine($"You have chosen {this.Name}!");
            Console.WriteLine($"{this.Type} Type Pokemon.");
            Console.WriteLine($"{this.Name} is a {this.Species}.");
            Console.WriteLine($"Your Pokemon's Health is {this.HP}.");
            Console.WriteLine($"   Attack | {this.Attack}");
            Console.WriteLine($"  Defense | {this.Defense}");
            Console.WriteLine($"    Speed | {this.Speed}");
            Console.WriteLine($"Abilities | {this.Ability1}, {this.Ability2}, and {this.Ability3}");
            Console.WriteLine("******************************************************************************");


        }

    }

    public class Ability
    {
        public string Name;
        public int Power;
        public decimal Accuracy;
        public string Description;

        public Ability(string Name, int Power, decimal Accuracy, string Description)
        {
            this.Name = Name;
            this.Power = Power;
            this.Accuracy = Accuracy;
            this.Description = Description;
        }
    }
}
