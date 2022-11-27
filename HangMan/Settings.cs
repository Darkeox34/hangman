using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Settings : Form
    {

        bool soundStateB = true;
        int difficultyS = 0;

        public Settings()
        {
            InitializeComponent();
        }

        private void soundState_Click(object sender, EventArgs e)
        {
            if (soundStateB)
            {
                soundState.Text = "Disabled";
                soundState.ForeColor = Color.Red;
                soundStateB = !soundStateB;
            }
            else
            {
                soundState.Text = "Enabled";
                soundState.ForeColor = Color.LawnGreen;
                soundStateB = !soundStateB;
            }

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void difficulty_Click(object sender, EventArgs e)
        {
            if (difficultyS == 0)
            {
                difficultyS = 1;
                difficulty.Text = "Medium";
                difficulty.ForeColor = Color.Orange;
            }
            else if (difficultyS == 1)
            {
                difficultyS = 2;
                difficulty.Text = "Hard";
                difficulty.ForeColor = Color.Red;
            }
            else if (difficultyS == 2)
            {
                difficultyS = 0;
                difficulty.Text = "Easy";
                difficulty.ForeColor = Color.LawnGreen;
            }
        }
    }
}
