namespace Car_Racing_Game
{
    partial class viewHighscore
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
            this.hsListView = new System.Windows.Forms.ListView();
            this.hsTitle = new System.Windows.Forms.Label();
            this.showMenu = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hsListView
            // 
            this.hsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsListView.HideSelection = false;
            this.hsListView.Location = new System.Drawing.Point(68, 67);
            this.hsListView.Name = "hsListView";
            this.hsListView.Size = new System.Drawing.Size(624, 334);
            this.hsListView.TabIndex = 0;
            this.hsListView.UseCompatibleStateImageBehavior = false;
            this.hsListView.View = System.Windows.Forms.View.Details;
            // 
            // hsTitle
            // 
            this.hsTitle.AutoSize = true;
            this.hsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsTitle.Location = new System.Drawing.Point(234, 9);
            this.hsTitle.Name = "hsTitle";
            this.hsTitle.Size = new System.Drawing.Size(306, 42);
            this.hsTitle.TabIndex = 1;
            this.hsTitle.Text = "Highscore Table";
            // 
            // showMenu
            // 
            this.showMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.showMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMenu.Location = new System.Drawing.Point(94, 407);
            this.showMenu.Name = "showMenu";
            this.showMenu.Size = new System.Drawing.Size(162, 41);
            this.showMenu.TabIndex = 2;
            this.showMenu.Text = "Main Menu";
            this.showMenu.UseVisualStyleBackColor = false;
            this.showMenu.Click += new System.EventHandler(this.showMenu_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(565, 407);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 41);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // viewHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showMenu);
            this.Controls.Add(this.hsTitle);
            this.Controls.Add(this.hsListView);
            this.MaximizeBox = false;
            this.Name = "viewHighscore";
            this.Text = "Highscore";
            this.Load += new System.EventHandler(this.viewHighscore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView hsListView;
        private System.Windows.Forms.Label hsTitle;
        private System.Windows.Forms.Button showMenu;
        private System.Windows.Forms.Button exitBtn;
    }
}