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
    public partial class Game : Form
    {
        private char c;
        public static int score;
        private int counter;
        private List<string> usedWord;
        Table User;
        //private int wordCount;

        public Game()
        {
            score = 0;
            InitializeComponent();
            usedWord = new List<string>();
            Random random = new Random();
            c = (char)('a' + random.Next(0, 26));
            InitializeGame();
            InitializeTimer();
            textBoxAns.KeyDown += new KeyEventHandler(tb_keyDown);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxAns != null
                && Word.WordCheck(Word.CleanAnswer(textBoxAns.Text)) == true 
                && Word.CleanAnswer(textBoxAns.Text)[0] == c 
                && !usedWord.Contains(Word.CleanAnswer(textBoxAns.Text)))
            {
                usedWord.Add(Word.CleanAnswer(textBoxAns.Text));
                score += textBoxAns.Text.Length * 10;
                string ans = Word.CleanAnswer(textBoxAns.Text);
                c = ans[ans.Length - 1];
                InitializeGame();
            } else if (usedWord.Contains(Word.CleanAnswer(textBoxAns.Text)))
            {
                timer1.Stop();
                MessageBox.Show("You have used this word, try another");
                timer1.Start();
            }
            else if (textBoxAns != null
                && Word.WordCheck(Word.CleanAnswer(textBoxAns.Text)) == false)
            {
                timer1.Stop();
                MessageBox.Show("It seems that I can't understand your word :/");
                timer1.Start();
            }
        }

        private void InitializeGame()
        {
            counter = 10;
            textBoxAns.Text = "";
            labelScore.Text = "Your Score: " + score.ToString();
            labelQuestion.Text = "Word starts with " + Char.ToUpper(c);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "Time: " + counter.ToString();
            counter -= 1;
            if (counter == -1)
            {
                timer1.Stop();
                MessageBox.Show("My time is running out! Game over! Good bye :(");
                this.Hide();

                using (var db = new UserModel())
                {
                    Table User = new Table
                    {
                        highscore = Game.score,
                        username = UsernameForm.username,
                    };
                    db.Tables.Add(User);
                    db.SaveChanges();
                }
                Form1 form = new Form1();
                form.Closed += (s, args) => this.Close();
                form.Show();
                this.Hide();
            }
        }

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(timer1_Tick);
        }

        public void tb_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitAnswer();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void SubmitAnswer()
        {
            if (textBoxAns != null
                    && Word.WordCheck(Word.CleanAnswer(textBoxAns.Text)) == true
                    && Word.CleanAnswer(textBoxAns.Text)[0] == c
                    && !usedWord.Contains(Word.CleanAnswer(textBoxAns.Text)))
            {
                usedWord.Add(Word.CleanAnswer(textBoxAns.Text));
                score += textBoxAns.Text.Length * 10;
                string ans = Word.CleanAnswer(textBoxAns.Text);
                c = ans[ans.Length - 1];
                InitializeGame();
            }
            else if (usedWord.Contains(Word.CleanAnswer(textBoxAns.Text)))
            {
                timer1.Stop();
                MessageBox.Show("You have used this word, try another");
                timer1.Start();
            }
            else if (textBoxAns != null
                && Word.WordCheck(Word.CleanAnswer(textBoxAns.Text)) == false)
            {
                timer1.Stop();
                MessageBox.Show("It seems that I can't understand your word :/");
                timer1.Start();
            }
        }
    }
}
