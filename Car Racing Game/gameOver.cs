﻿using System;
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
    public partial class gameOver : Form
    {
        public gameOver()
        {
            InitializeComponent();
        }

        private void gameOver_Load(object sender, EventArgs e)
        {
            resultLbl.Text = "Score: "+globalClass.score.ToString();
        }
    }
}
