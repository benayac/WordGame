namespace WordGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnPlayCPU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.BackgroundImage = global::WordGame.Properties.Resources.button2;
            this.buttonSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubmit.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.Location = new System.Drawing.Point(356, 205);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(152, 61);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Play Solo";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.BackgroundImage = global::WordGame.Properties.Resources.button2;
            this.buttonHowToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHowToPlay.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.Location = new System.Drawing.Point(356, 376);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(152, 61);
            this.buttonHowToPlay.TabIndex = 2;
            this.buttonHowToPlay.Text = "How To Play";
            this.buttonHowToPlay.UseVisualStyleBackColor = false;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(266, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "BattleText KW!";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighscore.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.ForeColor = System.Drawing.Color.White;
            this.lblHighscore.Location = new System.Drawing.Point(349, 155);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(166, 27);
            this.lblHighscore.TabIndex = 4;
            this.lblHighscore.Text = "Highest Score:";
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.btnLeaderboard.BackgroundImage = global::WordGame.Properties.Resources.button2;
            this.btnLeaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeaderboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnLeaderboard.Location = new System.Drawing.Point(356, 455);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(152, 61);
            this.btnLeaderboard.TabIndex = 6;
            this.btnLeaderboard.Text = "Leaderboards";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // btnPlayCPU
            // 
            this.btnPlayCPU.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayCPU.BackgroundImage = global::WordGame.Properties.Resources.button2;
            this.btnPlayCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayCPU.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlayCPU.Location = new System.Drawing.Point(354, 290);
            this.btnPlayCPU.Name = "btnPlayCPU";
            this.btnPlayCPU.Size = new System.Drawing.Size(152, 61);
            this.btnPlayCPU.TabIndex = 7;
            this.btnPlayCPU.Text = "Play vs CPU";
            this.btnPlayCPU.UseVisualStyleBackColor = false;
            this.btnPlayCPU.Click += new System.EventHandler(this.btnPlayCPU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordGame.Properties.Resources.bakcground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 538);
            this.Controls.Add(this.btnPlayCPU);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHowToPlay);
            this.Controls.Add(this.buttonSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonHowToPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.Button btnPlayCPU;
    }
}

