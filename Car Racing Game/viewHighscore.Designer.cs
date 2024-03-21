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
            this.SuspendLayout();
            // 
            // hsListView
            // 
            this.hsListView.HideSelection = false;
            this.hsListView.Location = new System.Drawing.Point(218, 62);
            this.hsListView.Name = "hsListView";
            this.hsListView.Size = new System.Drawing.Size(211, 171);
            this.hsListView.TabIndex = 0;
            this.hsListView.UseCompatibleStateImageBehavior = false;
            this.hsListView.View = System.Windows.Forms.View.Details;
            // 
            // viewHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hsListView);
            this.Name = "viewHighscore";
            this.Text = "Highscore";
            this.Load += new System.EventHandler(this.viewHighscore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView hsListView;
    }
}