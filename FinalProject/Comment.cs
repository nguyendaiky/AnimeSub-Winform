using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json;

namespace FinalProject
{
    public partial class Comment : UserControl
    {
        public Comment(string line)
        {
            InitializeComponent();
            if (line != "")
            {
                pctAvatar.Image = cv2.resize(Properties.Resources.noavatar, new Size(pctAvatar.Width, pctAvatar.Height));
                DataComment cmtData = JsonConvert.DeserializeObject<DataComment>(line);
                lbComment.Text = cmtData.cmt;
                lbName.Text = cmtData.username;
                try
                {
                    string path = Application.StartupPath + "\\User\\" + cmtData.username + ".jfif";
                    pctAvatar.Image = cv2.resize(cv2.imread(path), new Size(pctAvatar.Width, pctAvatar.Height));
                }
                catch { }
            }
        }
    }
}
