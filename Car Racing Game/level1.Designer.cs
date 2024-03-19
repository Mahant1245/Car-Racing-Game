namespace Car_Racing_Game
{
    partial class gameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.sideTile3 = new System.Windows.Forms.PictureBox();
            this.sideTile1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sideTile2 = new System.Windows.Forms.PictureBox();
            this.sideTile4 = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.BackColor = System.Drawing.Color.Red;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(2, 9);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(123, 29);
            this.timeLeftLabel.TabIndex = 1;
            this.timeLeftLabel.Text = "Time Left";
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.Image = global::Car_Racing_Game.Properties.Resources.heart;
            this.heart1.Location = new System.Drawing.Point(424, 7);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(27, 22);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 3;
            this.heart1.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.Image = global::Car_Racing_Game.Properties.Resources.heart;
            this.heart3.Location = new System.Drawing.Point(488, 8);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(25, 21);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 4;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.Image = global::Car_Racing_Game.Properties.Resources.heart;
            this.heart2.Location = new System.Drawing.Point(457, 8);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(25, 21);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 5;
            this.heart2.TabStop = false;
            // 
            // sideTile3
            // 
            this.sideTile3.Image = ((System.Drawing.Image)(resources.GetObject("sideTile3.Image")));
            this.sideTile3.Location = new System.Drawing.Point(478, -12);
            this.sideTile3.Name = "sideTile3";
            this.sideTile3.Size = new System.Drawing.Size(44, 228);
            this.sideTile3.TabIndex = 7;
            this.sideTile3.TabStop = false;
            this.sideTile3.Tag = "sideTile";
            // 
            // sideTile1
            // 
            this.sideTile1.Image = ((System.Drawing.Image)(resources.GetObject("sideTile1.Image")));
            this.sideTile1.Location = new System.Drawing.Point(-7, -12);
            this.sideTile1.Name = "sideTile1";
            this.sideTile1.Size = new System.Drawing.Size(39, 228);
            this.sideTile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sideTile1.TabIndex = 8;
            this.sideTile1.TabStop = false;
            this.sideTile1.Tag = "sideTile";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Car_Racing_Game.Properties.Resources.userCar;
            this.player.Location = new System.Drawing.Point(221, 305);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(65, 81);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 10;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sideTile2
            // 
            this.sideTile2.Image = ((System.Drawing.Image)(resources.GetObject("sideTile2.Image")));
            this.sideTile2.Location = new System.Drawing.Point(-7, 243);
            this.sideTile2.Name = "sideTile2";
            this.sideTile2.Size = new System.Drawing.Size(39, 228);
            this.sideTile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sideTile2.TabIndex = 11;
            this.sideTile2.TabStop = false;
            this.sideTile2.Tag = "sideTile";
            // 
            // sideTile4
            // 
            this.sideTile4.Image = ((System.Drawing.Image)(resources.GetObject("sideTile4.Image")));
            this.sideTile4.Location = new System.Drawing.Point(478, 243);
            this.sideTile4.Name = "sideTile4";
            this.sideTile4.Size = new System.Drawing.Size(44, 256);
            this.sideTile4.TabIndex = 12;
            this.sideTile4.TabStop = false;
            this.sideTile4.Tag = "sideTile";
            // 
            // rock
            // 
            this.rock.BackColor = System.Drawing.Color.Transparent;
            this.rock.Image = global::Car_Racing_Game.Properties.Resources.rock;
            this.rock.Location = new System.Drawing.Point(87, 148);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(50, 31);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock.TabIndex = 13;
            this.rock.TabStop = false;
            this.rock.Tag = "obstacle";
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = global::Car_Racing_Game.Properties.Resources.car2;
            this.car2.Location = new System.Drawing.Point(432, 90);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(40, 67);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 15;
            this.car2.TabStop = false;
            this.car2.Tag = "obstacle";
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::Car_Racing_Game.Properties.Resources.car1;
            this.car1.Location = new System.Drawing.Point(311, 183);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(50, 76);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 16;
            this.car1.TabStop = false;
            this.car1.Tag = "obstacle";
            // 
            // car3
            // 
            this.car3.BackColor = System.Drawing.Color.Transparent;
            this.car3.Image = global::Car_Racing_Game.Properties.Resources.car3;
            this.car3.Location = new System.Drawing.Point(38, 243);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(61, 76);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 17;
            this.car3.TabStop = false;
            this.car3.Tag = "obstacle";
            // 
            // car4
            // 
            this.car4.BackColor = System.Drawing.Color.Transparent;
            this.car4.Image = global::Car_Racing_Game.Properties.Resources.car4;
            this.car4.Location = new System.Drawing.Point(131, 7);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(49, 64);
            this.car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car4.TabIndex = 18;
            this.car4.TabStop = false;
            this.car4.Tag = "obstacle";
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Racing_Game.Properties.Resources.roadMain;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.sideTile4);
            this.Controls.Add(this.sideTile2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.sideTile1);
            this.Controls.Add(this.sideTile3);
            this.Controls.Add(this.car2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "gameForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideTile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox sideTile3;
        private System.Windows.Forms.PictureBox sideTile1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox sideTile2;
        private System.Windows.Forms.PictureBox sideTile4;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car4;
    }
}