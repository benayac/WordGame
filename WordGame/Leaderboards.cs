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
            AddUser();
            for(int i = 0; i < userNameList.Count(); i++)
            {
                users += userNameList[i] + "\n";
                scores += Convert.ToString(scoreList[i]) + "\n";
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
