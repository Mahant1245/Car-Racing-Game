namespace Car_Racing_Game
{
    partial class mainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuForm));
            this.frontPic = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.soundBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.viewscoreBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frontPic)).BeginInit();
            this.SuspendLayout();
            // 
            // frontPic
            // 
            this.frontPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.frontPic.Image = ((System.Drawing.Image)(resources.GetObject("frontPic.Image")));
            this.frontPic.Location = new System.Drawing.Point(149, 52);
            this.frontPic.Name = "frontPic";
            this.frontPic.Size = new System.Drawing.Size(647, 410);
            this.frontPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.frontPic.TabIndex = 0;
            this.frontPic.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(310, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(329, 49);
            this.Title.TabIndex = 1;
            this.Title.Text = "Car Racing Game";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // soundBtn
            // 
            this.soundBtn.BackColor = System.Drawing.Color.LightBlue;
            this.soundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundBtn.Location = new System.Drawing.Point(802, 108);
            this.soundBtn.Name = "soundBtn";
            this.soundBtn.Size = new System.Drawing.Size(104, 36);
            this.soundBtn.TabIndex = 2;
            this.soundBtn.Text = "Sound";
            this.soundBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(802, 451);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(104, 36);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.LightBlue;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.Location = new System.Drawing.Point(802, 291);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(104, 36);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // viewscoreBtn
            // 
            this.viewscoreBtn.BackColor = System.Drawing.Color.LightBlue;
            this.viewscoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewscoreBtn.Location = new System.Drawing.Point(1, 108);
            this.viewscoreBtn.Name = "viewscoreBtn";
            this.viewscoreBtn.Size = new System.Drawing.Size(142, 91);
            this.viewscoreBtn.TabIndex = 5;
            this.viewscoreBtn.Text = "View Leaderboard";
            this.viewscoreBtn.UseVisualStyleBackColor = false;
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Lime;
            this.playBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.Location = new System.Drawing.Point(12, 291);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(104, 36);
            this.playBtn.TabIndex = 6;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(918, 499);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.viewscoreBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.soundBtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.frontPic);
            this.MaximizeBox = false;
            this.Name = "mainMenuForm";
            this.Text = "mainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.frontPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frontPic;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button soundBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button viewscoreBtn;
        private System.Windows.Forms.Button playBtn;
    }
}

