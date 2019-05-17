using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var db = new UserModel())
            {
                int score = 0;
                var query = from user in db.Tables select user;
                foreach(var item in query)
                {
                    if (item.highscore > score)
                    {
                        score = item.highscore;
                    }
                }
                lblHighscore.Text = "Highest Score: " + score;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to play!\n\nType a word starting with the determined letter!\nYour word's last character will be the next starting letter!");
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            Leaderboards leaderboards = new Leaderboards();
            leaderboards.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
