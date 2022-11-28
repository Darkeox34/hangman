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
    public partial class Game : Form
    {
        string[] words = System.IO.File.ReadAllLines(@"wordlist.txt");
        string word;
        Random rnd = new Random();
        public Game()
        {
            InitializeComponent();
        }

        private string newWord()
        {
            string word;
            int r = rnd.Next(0, 50000);
            word = words[r];
            return word;
        }

        private void lose()
        {
            newWord();
        }

        private void Game_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
