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
        private char c;
        private int score = 0;
        private int counter;
        //private int wordCount;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            InitializeTimer();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (Word.WordCheck(CleanAnswer(textBoxAns.Text)) == true && CleanAnswer(textBoxAns.Text)[0] == c)
            {
                //MessageBox.Show("YAY");
                score += textBoxAns.Text.Length * 10;
                InitializeGame();
            }
            else
                MessageBox.Show("Nah");
        }

        private string CleanAnswer(string answer)
        {
            answer = answer.Replace(" ", "").Replace(".", "").Replace(",", "");
            answer = answer.ToLower();
            return answer;
        }

        private void InitializeGame()
        {
            counter = 10;
            textBoxAns.Text = "";
            labelScore.Text = "Your Score: " + score.ToString();
            Random random = new Random();
            c = (char) ('a' + random.Next(0, 26));
            labelQuestion.Text = "Word starts with " + Char.ToUpper(c);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "Time: " + counter.ToString();
            counter-=1;
            if(counter == -1)
            {
                timer1.Stop();
                MessageBox.Show("Game Over");
                this.Close();
            }
        }

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(timer1_Tick);
        }
    }
}
