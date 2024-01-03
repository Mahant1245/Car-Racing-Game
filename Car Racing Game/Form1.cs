using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class mainMenuForm : Form
    {
        public mainMenuForm()
        {
            InitializeComponent();
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("to play........");
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            gameForm game = new gameForm();
            game.Show();
            this.Hide();
        }
    }
}
