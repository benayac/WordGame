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
        private List<string> userNameList, userNameCPUList;
        private List<int> scoreList, scoreCPUList;
        string users, usersCPU, scores, scoresCPU;
        int topScore = 0;
        int index = 0;
        public Leaderboards()
        {
            InitializeComponent();
            AddUser();
            SoloLeaderboard();
            CpuLeaderboard();

        }

        public void AddUser()
        {
            using (var db = new UserModel())
            {
                userNameList = new List<string>();
                scoreList = new List<int>();
                userNameCPUList = new List<string>();
                scoreCPUList = new List<int>();
                var query = from user in db.Tables where user.gamemode == "solo" select user;
                foreach (var item in query)
                {
                    userNameList.Add(item.username);
                    scoreList.Add(item.highscore);
                }
                query = from user in db.Tables where user.gamemode == "VS CPU" select user;
                foreach (var item in query)
                {
                    userNameCPUList.Add(item.username);
                    scoreCPUList.Add(item.highscore);
                }
            }
        }

        public void SoloLeaderboard()
        {
            if (userNameList.Count >= 5)
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
            }
            else
            {
                int x = scoreList.Count();
                for (int i = 0; i < x; i++)
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

        public void CpuLeaderboard()
        {
            if (userNameCPUList.Count >= 5)
            {
                usersCPU = "";
                scoresCPU = "";
                for (int i = 0; i < 5; i++)
                {
                    int x = scoreCPUList.Count();
                    for (int j = 0; j < x; j++)
                    {
                        if (scoreCPUList[j] > topScore)
                        {
                            topScore = scoreCPUList[j];
                            index = j;
                        }
                    }
                    usersCPU += userNameCPUList[index] + "\n";
                    userNameCPUList.RemoveAt(index);
                    scoresCPU += Convert.ToString(topScore) + "\n";
                    scoreCPUList.Remove(topScore);
                    topScore = 0;
                }
            }
            else
            {
                int x = scoreCPUList.Count();
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < scoreCPUList.Count(); j++)
                    {
                        if (scoreCPUList[j] > topScore)
                        {
                            topScore = scoreCPUList[j];
                            index = j;
                        }
                    }
                    usersCPU += userNameCPUList[index] + "\n";
                    userNameCPUList.RemoveAt(index);
                    scoresCPU += Convert.ToString(topScore) + "\n";
                    scoreCPUList.RemoveAt(index);
                    topScore = 0;
                }
            }
            lblCpuUsername.Text = usersCPU;
            lblCpuScore.Text = scoresCPU;
        }

    }
}
