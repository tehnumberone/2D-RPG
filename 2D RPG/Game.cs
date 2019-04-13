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
    public partial class Game : Form
    {
        Character NewChar = new Character();
        public Game()
        {
            Character Human = new Character();
            Charactercreation stats = new Charactercreation();
            InitializeComponent();
            label1.Text = NewChar.Introduce(Character.CharName);
            l1.Text = Human.Strength.ToString();
            l2.Text = Human.Attack.ToString();
            //l3.Text = Charactercreation.hp.ToString();
            l4.Text = Human.Vitality.ToString();
            l5.Text = Human.Agility.ToString();
        }
        public void Start()
        {

        }
        public void KeyboardControls(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            { Movement(0, -10); }
            if (e.KeyCode == Keys.S)
            { Movement(0, 10); }
            if (e.KeyCode == Keys.A)
            { Movement(-10, 0); }
            if (e.KeyCode == Keys.D)
            { Movement(10, 0); }
        }

        private void Movement(int x, int y)
        {
            pPlayer.Location = new Point(pPlayer.Location.X + x, pPlayer.Location.Y + y);
        }
    }
}
