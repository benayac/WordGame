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
        public static string username;
        public int mode;
        public UsernameForm(int mode)
        {
            this.mode = mode;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            username = tbName.Text;
            if (mode == 0)
            {
                Game game = new Game();
                game.Closed += (s, args) => this.Close();
                game.Show();
            } else if (mode == 1)
            {
                PlayVCPU play = new PlayVCPU();
                play.FormClosed += (s, args) => this.Close();
                play.Show();
            }
            this.Hide();
        }
    }
}
