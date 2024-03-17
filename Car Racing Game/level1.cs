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
    public partial class gameForm : Form
    {
        
        public gameForm()
        {
            InitializeComponent();
        }

        bool right;
        bool left;
        bool speedup;
        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }
            if(e.KeyCode == Keys.Space)
            {
                speedup = true;
            }
        }

        public void playerMovement()
        {
            if(right==true)
            {
                if(player.Left<430)
                {
                    player.Left += 5;
                }
            }
            if (left==true)
            {
                if(player.Left>0)
                {
                    player.Left-=5;
                }
            }
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            timer.Start();
           timeLeftLabel.BringToFront();//brings the label in front
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeftLabel.Text = globalClass.sec--.ToString();//change the text every sec
        }

        private void gameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                speedup = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playerMovement();
        }
    }

}
