using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        

        public viewHighscore()
        {
            InitializeComponent();
        }

        private void viewHighscore_Load(object sender, EventArgs e)
        {
            hsListView.Columns.Add("Name",100);
            hsListView.Columns.Add("Score",100);
            foreach(var (name,score)in globalClass.highscore)
            {
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(score.ToString());
                hsListView.Items.Add(item);
            }
        }
        public void showPreviousScore()
        {
            
        }
    }
}
