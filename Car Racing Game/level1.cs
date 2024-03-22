using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class gameForm : Form
    {
        
        //variables for movement
        bool right;
        bool left;
        bool speedup;
        int collision;
        bool wasColliding = false;//to check if it was already colliding before
        bool boostActive = false;
        Timer boostTimer = new Timer();
        
        

        public gameForm()
        {
            InitializeComponent();
            boostTimer.Interval = 5000; //5 seconds
            boostTimer.Tick += BoostTimer_Tick;
           
        }
        
        private void BoostTimer_Tick(object sender, EventArgs e)
        {
            boostActive = false;
            speedup = false; // Turn off speed boost after 3 seconds
            boostTimer.Stop(); // Stop the timer
        }

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
            if(e.KeyCode == Keys.Space && boostActive==true)
            {
                speedup = true;
                boostTimer.Start(); // Start the timer when speed boost is activated
            }
            if(e.KeyCode==Keys.Escape)
            {
                timer1.Stop();
                timer.Stop();
                //pops message box
                var result = MessageBox.Show("Do you want to resume?\n NO will result in game over","",MessageBoxButtons.YesNo,MessageBoxIcon.None);
                if(result==DialogResult.Yes)
                {
                    timer1.Start();
                    timer.Start();
                }
                if(result==DialogResult.No)//takes to gameover form
                {
                    gameOver finish = new gameOver();
                    finish.Show();
                    this.Hide();
                }
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
                    if (x.Top > 430)//checks if it has exited screen
                    {
                        x.Top = -100;
                    }
                    else
                    {
                        x.Top += 5;//continuously comes down by 5 pixels
                    }
                }
            }
        }

        public void obstacleMove()
        {
            foreach (Control y in this.Controls)
            {
                if ((string)y.Tag == "obstacle" &&!(y.Name=="boost"))
                {
                    if (y.Top > 550)
                    {
                        globalClass.score+= 1;//increase score
                        scoreLbl.Text = "Score:"+ globalClass.score.ToString();
                        y.Top = 0;//starts from top
                        Random rn = new Random();
                        int xloc, yloc;
                        //generates random value for x and y location
                        xloc = rn.Next(50, 420);
                        yloc = rn.Next(0, 150);
                        //assign random value to the obstacles
                        y.Location = new Point(xloc, yloc);
                    }
                    y.Top += 5;//everytime keep moving down 
                }

                if ((string)y.Tag == "obstacle" && y.Name == "boost")
                {
                    
                    if (y.Top > 1000)//to make it pop up less often
                    {
                        
                        boost.Visible = true;   
                        y.Top = 0;//starts from top
                        Random rn = new Random();
                        int xloc, yloc;
                        //generates random value for x and y location
                        xloc = rn.Next(50, 420);
                        yloc = rn.Next(0, 150);
                        //assign random value to the obstacles
                        y.Location = new Point(xloc, yloc);
                    }
                    y.Top += 5;//everytime keep moving down 
                }

            }

        }

        public void obstacleCollision()
        {
            //y1 for one obstacle and y2 for another obstacle
            foreach (Control y1 in this.Controls)
            {
                if ((string)y1.Tag == "obstacle")
                {
                    foreach (Control y2 in this.Controls)
                    {
                        if ((string)y2.Tag == "obstacle" && y1 != y2)
                        {
                            //checks if the new generated obstacle is colliding with previous one
                            if (y1.Bounds.IntersectsWith(y2.Bounds))
                                //generate new location for y1
                            {
                                
                                    Random rn = new Random();
                                    int xloc, yloc;
                                    //generates random value for x and y location
                                    xloc = rn.Next(50, 420);
                                    yloc = rn.Next(0, 150);
                                    //assign random value to the obstacles
                                    y1.Location = new Point(xloc, yloc);
                               
                            }
                        }
                    }
                }
            }

        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            timer.Start();
           timeLeftLabel.BringToFront();//brings the label in front
            boost.Visible = false;  
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
            if (e.KeyCode == Keys.Space&&boostActive)
            {
                speedup = false;
            }
            
        }
        

        public void playerCollision()//player with obstacle collision
        {
            
            //checks with every obstacles
            bool isColliding = player.Bounds.IntersectsWith(rock.Bounds) ||
                               player.Bounds.IntersectsWith(car1.Bounds) ||
                               player.Bounds.IntersectsWith(car2.Bounds) ||
                               player.Bounds.IntersectsWith(car3.Bounds) ||
                               player.Bounds.IntersectsWith(car4.Bounds) ||
                               player.Bounds.IntersectsWith(sideTile1.Bounds) ||
                               player.Bounds.IntersectsWith(sideTile2.Bounds) ||
                               player.Bounds.IntersectsWith(sideTile3.Bounds) ||
                               player.Bounds.IntersectsWith(sideTile4.Bounds);

            if (isColliding)
            {
                // Decrement life count only if not already colliding
                if (!wasColliding)
                {
                    collision++;

                }
                wasColliding = true;
                if (collision == 1)
                {
                    sound();
                    heart1.Visible = false;
                }
                if (collision == 2)
                {
                    sound();
                    heart2.Visible = false;
                }
                if (collision == 3)
                {
                    sound();
                    heart3.Visible = false;
                    timer1.Stop();
                    gameOverState();
                }
            }
            else
            {
                wasColliding = false;
            }

            if ( player.Bounds.IntersectsWith(boost.Bounds))
            {
                boostActive = true; // activate boost
                boost.Visible = false; // Hide the boost PictureBox
            }
        }

        public void sound()//plays sound
        {
            if (globalClass.playSound==true)
            {
                System.Media.SoundPlayer hit = new System.Media.SoundPlayer(Properties.Resources.sound);
                hit.Play();
            }
        }

        public void gameOverState()
        {
            if (collision == 3||globalClass.sec==0)
            {
                gameOver finish = new gameOver();
                finish.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//timer for realtime movement
        {
            //calling realtime methods
            playerMovement();
            sideTileFlow();
            obstacleMove();
            playerCollision();
            obstacleCollision();
            
        }
    }

}
