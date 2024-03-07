using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game//worked noww
{//this is global class
    internal static class globalClass
    {
        public static int sec;
        public static class time
        {
            public static DateTime beginTime { get; set; }
            public static DateTime gameTime { get; set; }
        }
    }
}