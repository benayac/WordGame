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
    public partial class Leaderboards : Form
    {
        private List<string> userNameList;
        private List<int> scoreList;
        public Leaderboards()
        {
            InitializeComponent();
            string users = "";
            string scores = "";
            int topScore = 0;
            int index = 0;
            AddUser();

            if(userNameList.Count >= 5)
            {
                users = "";
                scores = "";
                for (int i = 0; i < 5; i++)
                {
                    int x = scoreList.Count();
                    for (int j = 0; j < x; j++)
                    {
                        if (scoreList[j] > topScore)
                        {
                            topScore = scoreList[j];
                            index = j;
                        }
                    }
                    users += userNameList[index] + "\n";
                    userNameList.RemoveAt(index);
                    scores += Convert.ToString(topScore) + "\n";
                    scoreList.Remove(topScore);
                    topScore = 0;
                }
            } else
            {
                int x = scoreList.Count();
                for(int i = 0; i < x; i++)
                {
                    for (int j = 0; j < scoreList.Count(); j++)
                    {
                        if (scoreList[j] > topScore)
                        {
                            topScore = scoreList[j];
                            index = j;
                        }
                    }
                    users += userNameList[index] + "\n";
                    userNameList.RemoveAt(index);
                    scores += Convert.ToString(topScore) + "\n";
                    scoreList.RemoveAt(index);
                    topScore = 0;
                }
            }
            lblUsername.Text = users;
            lblScore.Text = scores;
        }

        public void AddUser()
        {
            using (var db = new UserModel())
            {
                userNameList = new List<string>();
                scoreList = new List<int>();
                var query = from user in db.Tables select user;
                foreach (var item in query)
                {
                    userNameList.Add(item.username);
                    scoreList.Add(item.highscore);
                }
            }
        }
    }
}
