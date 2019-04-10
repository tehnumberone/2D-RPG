using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG
{
    class Character // All the things that will be in char creation.
    {
        public static string CharName { get; set; } //Character name, you can set this in Character creation.
        public static string CharRace { get; set; } //Character race, you can set this in Character creation.
    }
    class Stats : Character // All the stats u can set in Character creation.
    {
        int Strength=5; //Default Strength level is 5.
        int Attack=5;   //Default Attack level is 5.
        int Health=5;   //Default Health level is 5.
        int Vitality=5; //Default Vitality level is 5.
        int Agility=5;  //Default Agility level is 5.
    }

}
