using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            resultLbl.Text = "Your Score: "+globalClass.score.ToString();
            nameBox.Text=Console.ReadLine();
            

        }

        private void highscoreBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")//validation check
            {
                MessageBox.Show("Bad input!!");
            }
            
            
                globalClass.playerName = nameBox.Text;
                nameBox.Clear();
                globalClass.highscore.Add((globalClass.playerName, globalClass.score));

            SaveScore(globalClass.playerName, globalClass.score);

            
           
            viewHighscore view = new viewHighscore();
            view.Show();
            this.Hide();
        }
        private static void SaveScore(string name, int score)
        {
           var sortedScores= globalClass.highscore.OrderByDescending<(string, int), int>(x => x.Item2);
            using (StreamWriter writer = new StreamWriter(globalClass.filePath, true))
            {
                writer.WriteLine(name + "," + score);
            }
        }

    }
}
