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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void bgameNew_Click(object sender, EventArgs e)
        {
            Visible = false;
            Charactercreation charscreen = new Charactercreation();
            charscreen.Show();
        }

        private void bgameLoad_Click(object sender, EventArgs e)
        {

        }

        private void bgameContinue_Click(object sender, EventArgs e)
        {

        }

        private void bgameSettings_Click(object sender, EventArgs e)
        {

        }

        private void bgameCredits_Click(object sender, EventArgs e)
        {

        }
    }
}
