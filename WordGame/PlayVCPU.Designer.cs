namespace WordGame
{
    partial class PlayVCPU
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lblPlayerWord = new System.Windows.Forms.Label();
            this.lblBotWord = new System.Windows.Forms.Label();
            this.lblBotScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bot TETI";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(108, 158);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(159, 37);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Yourname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(240, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "BattleText KW!";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(264, 422);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(330, 22);
            this.tbAnswer.TabIndex = 5;
            // 
            // lblPlayerWord
            // 
            this.lblPlayerWord.AutoSize = true;
            this.lblPlayerWord.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWord.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWord.ForeColor = System.Drawing.Color.White;
            this.lblPlayerWord.Location = new System.Drawing.Point(126, 318);
            this.lblPlayerWord.Name = "lblPlayerWord";
            this.lblPlayerWord.Size = new System.Drawing.Size(114, 41);
            this.lblPlayerWord.TabIndex = 6;
            this.lblPlayerWord.Text = "Word1";
            // 
            // lblBotWord
            // 
            this.lblBotWord.AutoSize = true;
            this.lblBotWord.BackColor = System.Drawing.Color.Transparent;
            this.lblBotWord.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotWord.ForeColor = System.Drawing.Color.White;
            this.lblBotWord.Location = new System.Drawing.Point(549, 318);
            this.lblBotWord.Name = "lblBotWord";
            this.lblBotWord.Size = new System.Drawing.Size(120, 41);
            this.lblBotWord.TabIndex = 7;
            this.lblBotWord.Text = "Word2";
            // 
            // lblBotScore
            // 
            this.lblBotScore.AutoSize = true;
            this.lblBotScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBotScore.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotScore.ForeColor = System.Drawing.Color.White;
            this.lblBotScore.Location = new System.Drawing.Point(629, 211);
            this.lblBotScore.Name = "lblBotScore";
            this.lblBotScore.Size = new System.Drawing.Size(61, 33);
            this.lblBotScore.TabIndex = 9;
            this.lblBotScore.Text = "200";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(156, 211);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(56, 33);
            this.lblPlayerScore.TabIndex = 8;
            this.lblPlayerScore.Text = "100";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(301, 236);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(180, 41);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "First letter";
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 1000;
            this.timerCounter.Tick += new System.EventHandler(this.timerCounter_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(35, 59);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(114, 33);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "Time: 10";
            // 
            // PlayVCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordGame.Properties.Resources.bakcground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 538);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblBotScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblBotWord);
            this.Controls.Add(this.lblPlayerWord);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "PlayVCPU";
            this.Text = "PlayVBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lblPlayerWord;
        private System.Windows.Forms.Label lblBotWord;
        private System.Windows.Forms.Label lblBotScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTimer;
    }
}