﻿namespace WordGame
{
    partial class Game
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
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelTime.Location = new System.Drawing.Point(485, 63);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(131, 37);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Time: 10";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelScore.Location = new System.Drawing.Point(485, 140);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(112, 37);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score: ";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelQuestion.Location = new System.Drawing.Point(145, 124);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(97, 37);
            this.labelQuestion.TabIndex = 7;
            this.labelQuestion.Text = "label1";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.BackgroundImage = global::WordGame.Properties.Resources.button2;
            this.buttonSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSubmit.Location = new System.Drawing.Point(281, 305);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(187, 89);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Enter";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxAns
            // 
            this.textBoxAns.BackColor = System.Drawing.Color.White;
            this.textBoxAns.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAns.Location = new System.Drawing.Point(173, 234);
            this.textBoxAns.Multiline = true;
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.Size = new System.Drawing.Size(409, 38);
            this.textBoxAns.TabIndex = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordGame.Properties.Resources.bakcground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 442);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxAns);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Timer timer1;
    }
}