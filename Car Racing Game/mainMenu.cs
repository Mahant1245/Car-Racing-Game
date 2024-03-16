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
            // opens the level1 form
            gameForm game = new gameForm();
            game.Show();
            this.Hide();

            globalClass.sec = 120;//sets the playing time to maximum of 3 min
            globalClass.time.beginTime=DateTime.Now;
            globalClass.time.gameTime=globalClass.time.beginTime.AddMinutes(3);
            //makes the endtime of the game to 3 mins 

        }

        private void soundBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
