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

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

            }
        }

        private void gameForm_Load(object sender, EventArgs e)//loadingggggggg
        {
           timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeftLabel.Text = globalClass.sec--.ToString();
        }
    }

}
