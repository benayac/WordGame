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
    public partial class PlayVCPU : Form
    {
        int botScore = 0;
        int userScore = 0;
        List<string> usedWord;
        char c;
        int counter;
        public PlayVCPU()
        {
            InitializeComponent();
            tbAnswer.KeyDown += new KeyEventHandler(tb_keyDown);
            usedWord = new List<string>();
            Random random = new Random();
            c = (char)('a' + random.Next(0, 26));
            lblUsername.Text = UsernameForm.username;
            lblPlayerWord.Text = "";
            lblBotWord.Text = "";
            InitializeBot();
            InitializeUser();
            InitializeCounter();
        }

        public void InitializeUser()
        {
            counter = 10;
            lblPlayerScore.Text = Convert.ToString(userScore);
            //lblPlayerWord.Text = tbAnswer.Text;
            //tbAnswer.Text = "";
            lblQuestion.Text = "First letter " + c;
            if(userScore >= 200)
            {
                timerCounter.Stop();
                MessageBox.Show("Congrats you win! :D");
                Close();
            }

        }
        public void InitializeBot()
        {
            lblBotScore.Text = Convert.ToString(botScore);
            lblQuestion.Text = "First letter " + c;
            if(botScore >= 200)
            {
                MessageBox.Show("I Win :D");
                Close();
            }

        }
       
        public void tb_keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                UserAnswer();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void UserAnswer()
        {
            if(tbAnswer != null
                && Word.CleanAnswer(tbAnswer.Text)[0] == c 
                && Word.WordCheck(Word.CleanAnswer(tbAnswer.Text)) == true
                && !usedWord.Contains(Word.CleanAnswer(tbAnswer.Text)))
            {
                usedWord.Add(Word.CleanAnswer(tbAnswer.Text));
                userScore += Word.CleanAnswer(tbAnswer.Text).Length * 10;
                string ans = Word.CleanAnswer(tbAnswer.Text);
                c = ans[ans.Length - 1];
                timerCounter.Stop();
                lblPlayerWord.Text = tbAnswer.Text;
                tbAnswer.Text = "";
                InitializeUser();
                BotTurn();
            }
            else
            {
                MessageBox.Show("Seems like your answer is wrong");
            }
        }

        public void BotAnswer()
        {
            string ans = Word.GetRandomWord(c);
            lblBotWord.Text = ans;
            botScore += ans.Length * 10;
            c = ans[ans.Length - 1];
            InitializeBot();
            InitializeUser();
            timerCounter.Start();
            tbAnswer.Enabled = true;
        }

        public void BotTurn()
        {
            tbAnswer.Enabled = false;
            Random random = new Random();
            counter = random.Next(1, 3);
            InitializeBotCounter();
        }

        public void InitializeCounter()
        {
            timerCounter = new Timer();
            timerCounter.Interval = 1000;
            timerCounter.Enabled = true;
            timerCounter.Tick += new System.EventHandler(timerCounter_Tick);
        }

        public void InitializeBotCounter()
        {
            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Enabled = true;
            timer2.Tick += new System.EventHandler(timer2_Tick);
        }

        private void timerCounter_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Time: " + counter.ToString();
            counter-=1;
            if(counter == -1)
            {
                timerCounter.Stop();
                MessageBox.Show("I Win :D");
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter -= 1;
            if(counter == -1)
            {
                timer2.Stop();
                BotAnswer();
            }
        }
    }
}
