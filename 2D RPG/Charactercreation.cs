using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_RPG
{
    public partial class Charactercreation : Form
    {
        //load in all characters
        //
        public Charactercreation()
        {
            InitializeComponent();
        }

        public float character(float charactercreation)
        {
            if (charactercreation == 1)
            {
                //save file to directory
            }
            return charactercreation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Character.CharName = inputCharname.Text;
            Character.CharRace = inputRace.SelectedText;
            Visible = false;
            Game maingame = new Game();
            maingame.Show();
            character(1);
        }

        private void inputRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterStats.Visible = true;
            if (inputRace.SelectedIndex == 0)//0 is Human
            {
                Character Human = new Character();
                statsStrength.Value = Human.Strength;
                statsAttack.Value = Human.Attack;
                statsHealth.Value = Human.Health + 3;
                statsVitality.Value = Human.Vitality;
                statsAgility.Value = Human.Agility;
            }
            if (inputRace.SelectedIndex == 1)//1 is Chicken
            {
                Character Chicken = new Character();
                statsStrength.Value = Chicken.Strength - 2;
                statsAttack.Value = Chicken.Attack - 2;
                statsHealth.Value = Chicken.Health - 2;
                statsVitality.Value = Chicken.Vitality - 2;
                statsAgility.Value = Chicken.Agility - 2;
            }
            if (inputRace.SelectedIndex == 2)//2 is Cow
            {
                Character Cow = new Character();
                statsStrength.Value = Cow.Strength + 1;
                statsAttack.Value = Cow.Attack + 1;
                statsHealth.Value = Cow.Health + 1;
                statsVitality.Value = Cow.Vitality + 1;
                statsAgility.Value = Cow.Agility;
            }

        }
        public void checkcap(object sender, EventArgs e)
        {
            NumericUpDown stat = (NumericUpDown)sender;
            if (statsStrength.Value + statsHealth.Value + statsAttack.Value + statsAgility.Value + statsVitality.Value >= 30)//Max total stats is 30
            {
                if (stat.Name == "statsStrength")
                {
                    statsStrength.Value--;
                }
                if (stat.Name == "statsHealth")
                {
                    statsHealth.Value--;
                }
                if (stat.Name == "statsAttack")
                {
                    statsAttack.Value--;
                }
                if (stat.Name == "statsAgility")
                {
                    statsAgility.Value--;
                }
                if (stat.Name == "statsVitality")
                {
                    statsVitality.Value--;
                }
                MessageBox.Show("Too high amigo!");
            }
        }
    }


}
