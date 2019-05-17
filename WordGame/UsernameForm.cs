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
    public partial class UsernameForm : Form
    {
        public UsernameForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (var db = new UserModel())
            {
                Table User = new Table
                {
                    highscore = Game.score,
                    username = tbName.Text,
                };
                db.Tables.Add(User);
                db.SaveChanges();
                Close();
            }
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
