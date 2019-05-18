namespace WordGame
{
    partial class Leaderboards
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCpuScore = new System.Windows.Forms.Label();
            this.lblCpuUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(296, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leaderboards";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(37, 161);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(144, 33);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(283, 161);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(85, 33);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score";
            // 
            // lblCpuScore
            // 
            this.lblCpuScore.AutoSize = true;
            this.lblCpuScore.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuScore.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblCpuScore.Location = new System.Drawing.Point(678, 161);
            this.lblCpuScore.Name = "lblCpuScore";
            this.lblCpuScore.Size = new System.Drawing.Size(85, 33);
            this.lblCpuScore.TabIndex = 4;
            this.lblCpuScore.Text = "Score";
            // 
            // lblCpuUsername
            // 
            this.lblCpuUsername.AutoSize = true;
            this.lblCpuUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuUsername.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuUsername.ForeColor = System.Drawing.Color.Transparent;
            this.lblCpuUsername.Location = new System.Drawing.Point(432, 161);
            this.lblCpuUsername.Name = "lblCpuUsername";
            this.lblCpuUsername.Size = new System.Drawing.Size(144, 33);
            this.lblCpuUsername.TabIndex = 3;
            this.lblCpuUsername.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(188, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Solo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(567, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "VS CPU";
            // 
            // Leaderboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WordGame.Properties.Resources.bakcground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCpuScore);
            this.Controls.Add(this.lblCpuUsername);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Name = "Leaderboards";
            this.Text = "Leaderboards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCpuScore;
        private System.Windows.Forms.Label lblCpuUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}