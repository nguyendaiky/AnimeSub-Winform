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
    public partial class WatchFilm : Form
    {
        DataRow row;
        bool isZoom;
        public WatchFilm(DataRow dr)
        {
            InitializeComponent();
            row = dr;
            string path = "";
            if (Convert.ToInt32(row["NumEp"]) != 0)
            {
                path = Application.StartupPath + "\\Video\\" + row["Name"].ToString() + "\\1.mp4";
            }
            else
            {
                path = Application.StartupPath + "\\Video\\" + row["Name"].ToString() + "\\Movie 1.mp4";
            }
            WMP.URL = "";

        }

        private void WatchFilm_Load(object sender, EventArgs e)
        {
            Button_Ep();
            this.Text = row["NameSort"].ToString();
            string path_ico = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif";
            using (Bitmap bm = (Bitmap)Image.FromFile(path_ico))
            {
                this.Icon = Icon.FromHandle(bm.GetHicon());
            }
            isZoom = false;
        }

        private void Button_Ep()
        {
            int ep = Convert.ToInt32(row["NumEp"]);
            int mov = Convert.ToInt32(row["NumMovie"]);
            if (ep > 0)
            {
                for (int idx = 1; idx <= ep; idx++)
                {
                    Button btn = new Button()
                    {
                        Width = 60,
                        Height = 30,
                        Text = idx.ToString()
                    };
                    btn.Click += Ep_Click;
                    LayoutPnlEp.Controls.Add(btn);
                }
            }
            if (mov > 0)
            {
                for (int idx = 1; idx <= mov; idx++)
                {
                    Button btn = new Button()
                    {
                        Width = 60,
                        Height = 30,
                        Text = "Movie " + idx.ToString(),
                        Cursor = Cursors.Hand                        
                    };
                    btn.Click += Ep_Click;
                    LayoutPnlEp.Controls.Add(btn);
                }
            }
        }

        private void Ep_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string path = Application.StartupPath + "\\Video\\" + row["Name"].ToString() + "\\" + btn.Text + ".mp4";
            WMP.URL = path;
        }
   
        private void WatchFilm_ClientSizeChanged(object sender, EventArgs e)
        {
            LayoutPnlEp.Visible = !LayoutPnlEp.Visible;
            if (isZoom)
            {
                WMP.Dock = DockStyle.Top;
            }
            else
            {
                WMP.Dock = DockStyle.Fill;
            }
            isZoom = !isZoom;
        }
    }
}
