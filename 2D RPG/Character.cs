using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG
{
    public class Character // All the things that will be in char creation.
    {
        public static string CharName { get; set; } //Character name, you can set this in Character creation.
        public static string CharRace { get; set; } //Character race, you can set this in Character creation.
        public int Strength; //Default Strength level is 5.
        public int Attack;   //Default Attack level is 5.
        public int Health;   //Default Health level is 5.
        public int Vitality; //Default Vitality level is 5.
        public int Agility;  //Default Agility level is 5.

        public string Introduce(string CharName) // say hello to the player!
        {
            string introduction = "Hi " + CharName + " Welcome to 2D RPG!";
            return introduction;
        }
    }
}
