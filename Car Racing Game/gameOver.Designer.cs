namespace Car_Racing_Game
{
    partial class gameOver
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
            this.resultLbl = new System.Windows.Forms.Label();
            this.enterNameLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.highscoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(59, 48);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(35, 13);
            this.resultLbl.TabIndex = 0;
            this.resultLbl.Text = "Score";
            // 
            // enterNameLbl
            // 
            this.enterNameLbl.AutoSize = true;
            this.enterNameLbl.Location = new System.Drawing.Point(26, 88);
            this.enterNameLbl.Name = "enterNameLbl";
            this.enterNameLbl.Size = new System.Drawing.Size(174, 13);
            this.enterNameLbl.TabIndex = 1;
            this.enterNameLbl.Text = "Enter your name for highscore table";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(62, 134);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.Text = "Enter here";
            // 
            // highscoreBtn
            // 
            this.highscoreBtn.Location = new System.Drawing.Point(12, 192);
            this.highscoreBtn.Name = "highscoreBtn";
            this.highscoreBtn.Size = new System.Drawing.Size(203, 23);
            this.highscoreBtn.TabIndex = 4;
            this.highscoreBtn.Text = "view highscore";
            this.highscoreBtn.UseVisualStyleBackColor = true;
            this.highscoreBtn.Click += new System.EventHandler(this.highscoreBtn_Click);
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highscoreBtn);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.enterNameLbl);
            this.Controls.Add(this.resultLbl);
            this.Name = "gameOver";
            this.Text = "gameOver";
            this.Load += new System.EventHandler(this.gameOver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label enterNameLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button highscoreBtn;
    }
}