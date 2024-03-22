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
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.Location = new System.Drawing.Point(298, 9);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(155, 55);
            this.resultLbl.TabIndex = 0;
            this.resultLbl.Text = "Score";
            // 
            // enterNameLbl
            // 
            this.enterNameLbl.AutoSize = true;
            this.enterNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLbl.Location = new System.Drawing.Point(28, 124);
            this.enterNameLbl.Name = "enterNameLbl";
            this.enterNameLbl.Size = new System.Drawing.Size(749, 52);
            this.enterNameLbl.TabIndex = 1;
            this.enterNameLbl.Text = "Enter your name for highscore table";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(323, 193);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(147, 40);
            this.nameBox.TabIndex = 2;
            this.nameBox.Text = "Enter here";
            // 
            // highscoreBtn
            // 
            this.highscoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.highscoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreBtn.Location = new System.Drawing.Point(289, 288);
            this.highscoreBtn.Name = "highscoreBtn";
            this.highscoreBtn.Size = new System.Drawing.Size(221, 60);
            this.highscoreBtn.TabIndex = 4;
            this.highscoreBtn.Text = "view highscore";
            this.highscoreBtn.UseVisualStyleBackColor = false;
            this.highscoreBtn.Click += new System.EventHandler(this.highscoreBtn_Click);
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
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