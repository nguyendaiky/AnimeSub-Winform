using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class AnimeSub : Form
    {

        

        public AnimeSub()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            WatchVideo.URL = "D:/CLOUDX/Courses/Nam3/C#/Final_Project/DataVideo/Cô Gái Có Thể Nhìn Thấy Chúng/1.mp4";
            WatchVideo.settings.autoStart = true;
        }
    }
}
