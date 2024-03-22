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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            resultLbl.Text = "Your Score: " + globalClass.score.ToString();//updates the score
            nameBox.Text = Console.ReadLine();

            //read all previous score and store in highscore list
            if (File.Exists(globalClass.filePath))
            {
                globalClass.highscore = File.ReadAllLines(globalClass.filePath)
                                 .Select(line => line.Split(','))
                                 .Where(parts => parts.Length == 2)
                                 .Select(parts => (parts[0], int.Parse(parts[1])))
                                 .ToList();
            }

        }

        private void highscoreBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "")//validation check
            {
                MessageBox.Show("Bad input!!");
                return;
            }

            globalClass.playerName = nameBox.Text;
            nameBox.Clear();
            SaveScore(globalClass.playerName, globalClass.score);
            
            //closes this form
            viewHighscore finish = new viewHighscore();
            finish.Show();
            this.Hide();
        }

        private void SaveScore(string name, int score)
        {
            /// Add the new score to the list
            globalClass.highscore.Add((name, score));

            // Sort the scores in descending order
            globalClass.highscore = globalClass.highscore.OrderByDescending(s => s.Item2).ToList();//got from web

            //Takes the name and score and Write the sorted scores to the file
            using (StreamWriter writer = new StreamWriter(globalClass.filePath))
            {
                foreach (var scoreEntry in globalClass.highscore)
                {
                    writer.WriteLine($"{scoreEntry.Item1},{scoreEntry.Item2}");
                        
                }
            }
        }
    }
}
