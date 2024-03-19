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
        //variables for movement
        bool right;
        bool left;
        bool speedup;
        int collision;
        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            //this checks if A,D or spacebar is pressed
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
                if(player.Left<430)//checks if the pixels are within the boundary of the form
                {
                    player.Left += 5;
                    //takes the players distance from left edge and move it 5 pixels further apart
                }
            }
            if (left==true)
            {
                if(player.Left>0)//checks if the pixels are within the boundary of the form
                {
                    player.Left-=5;
                    //takes the players distance from left edge and move it 5 pixels closer to left edge
                }
            }
            if (speedup==true)
            {
                sideTileFlow();//this will make the tile flow double
                obstacleMove();
            }

        }
        public void sideTileFlow()//method to flow the side tile
        {
            foreach(Control x in this.Controls)
            {
                if ((string)x.Tag == "sideTile")
                {
                    if (x.Top > 430)
                    {
                        x.Top = -100;
                    }
                    else
                    {
                        x.Top += 5;
                    }
                }
            }
        }
        public void obstacleMove()
        {
            foreach (Control y in this.Controls)
            {
                if ((string)y.Tag == "obstacle")
                {
                    if (y.Top > 550)
                    {
                        y.Top = 0;//starts from top
                        Random rn = new Random();
                        int xloc, yloc;
                        //generates random value for x and y location
                        xloc = rn.Next(50, 450);
                        yloc = rn.Next(0, 150);
                        //assign random value to the obstacles
                        y.Location = new Point(xloc, yloc);
                    }
                    y.Top += 5;//everytime keep moving down 
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
            //makes sure that it is set to false as soon as the key is released
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

        public void playerCollision()//player with obstacle collision
        {

            if (player.Bounds.IntersectsWith(rock.Bounds) || player.Bounds.IntersectsWith(car1.Bounds)
                || player.Bounds.IntersectsWith(car2.Bounds) || player.Bounds.IntersectsWith(car3.Bounds)
                || player.Bounds.IntersectsWith(car4.Bounds) || player.Bounds.IntersectsWith(car1.Bounds)
                || player.Bounds.IntersectsWith(sideTile1.Bounds) || player.Bounds.IntersectsWith(sideTile2.Bounds)
                || player.Bounds.IntersectsWith(sideTile3.Bounds) || player.Bounds.IntersectsWith(sideTile4.Bounds)
              )
            {
                obstacleMove();
                collision +=1;
                updateLife();

            }

        }

        public void updateLife()
        {
           if(collision==1)
            {
                heart1.Visible = false;
            }
            if (collision == 2)
            {
                heart2.Visible = false;
            }
            if (collision == 3)
            {
                heart3.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//timer for realtime movement
        {
            playerMovement();
            sideTileFlow();
            obstacleMove();
           
            

            
            
        }
    }

}
