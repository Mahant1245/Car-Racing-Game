using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{//this is global class
    internal static class globalClass
    {
        public static int sec;//no.of available for game
        public static int score;//total score
        public static string playerName = "";
        public static string filePath = "highscore.txt";
       public static List<(string, int)> highscore = new List<(string, int)>();
        public static bool playSound=true;
        public static class time //time class that can be accessed from every form.
        {
            public static DateTime beginTime { get; set; }
            public static DateTime gameTime { get; set; }
        }

        
    }
}