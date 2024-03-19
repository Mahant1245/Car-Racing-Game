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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Car_Racing_Game.Properties.Resources.heart;
            this.pictureBox2.Location = new System.Drawing.Point(424, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Car_Racing_Game.Properties.Resources.heart;
            this.pictureBox3.Location = new System.Drawing.Point(488, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Car_Racing_Game.Properties.Resources.heart;
            this.pictureBox4.Location = new System.Drawing.Point(457, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(478, -12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 228);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "sideTile";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-7, -12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 228);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "sideTile";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "sideTile";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(478, 243);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(44, 256);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "sideTile";
            // 
            // rock
            // 
            this.rock.BackColor = System.Drawing.Color.Transparent;
            this.rock.Image = global::Car_Racing_Game.Properties.Resources.rock;
            this.rock.Location = new System.Drawing.Point(60, 76);
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
            this.car1.Location = new System.Drawing.Point(247, 170);
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
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.car2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "gameForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car4;
    }
}