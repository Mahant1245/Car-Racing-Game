using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_Racing_Game
{
    public partial class viewHighscore : Form
    {
        
        bool isInitialized=false;
        public viewHighscore()
        {
            InitializeComponent();
        }

        private void viewHighscore_Load(object sender, EventArgs e)
        {
            //load the list with two different column
            hsListView.Columns.Add("Name",100);
            hsListView.Columns.Add("Score",100);

            hsListView.Items.Clear();//clear
            globalClass.highscore = new List<(string, int)>();//newlist
            
            //reads from file and displays in listview
            if (File.Exists(globalClass.filePath))
            {

                string[] contents = File.ReadAllLines(globalClass.filePath);
                foreach (string line in contents)
                {
                    string[] parts = line.Split(',');//separates name and score
                    if (parts.Length == 2)
                    {
                        //add name to name column and score to score column
                        ListViewItem item = new ListViewItem(parts[0]);
                        item.SubItems.Add(parts[1]);
                        hsListView.Items.Add(item);

                    }
                }
            }
        }

        private void showMenu_Click(object sender, EventArgs e)
        {
            globalClass.sec = 0;//resets the value
            globalClass.score = 0;
            mainMenuForm menu = new mainMenuForm();
            menu.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
