using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class Describe : Form
    {
        DataRow row;
        public Describe(DataRow dr)
        {
            InitializeComponent();
            row = dr;
        }

        private void Describe_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        
        private void Load_Image()
        {
            Image preview;
            Image img = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif");
            try
            {
                preview = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\preview.jfif");
            }catch
            {
                preview = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif");
            }
            preview = cv2.resize_width(preview, pnlPreview.Width);
            pnlPreview.BackgroundImage = preview;
            Image resized = cv2.resize(img, new Size(pctImage.Width, pctImage.Height));
            pctImage.Image = resized;
        }
        private void Load_Name()
        {
            lbName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Describe.txt";
            string s = File.ReadAllText(path);
            lbDescribe.Text = s;

            lbType.Text = row["Type"].ToString();
            lbDirector.Text = row["Director"].ToString();
            lbStudio.Text = row["Studio"].ToString();
            lbSeason.Text = row["Season"].ToString();
            lbView.Text = string.Format("{0:N}", Convert.ToInt32(row["View"])).Replace(".00", "");
            lbNumEp.Text = row["NumEp"].ToString() + " Tập";
            lbNumEp.Text = row["NumMovie"].ToString() + " Tập";
        }
        private void Load_Data()
        {
            Load_Image();
            Load_Name();
        }

        private void lbWatch_Click(object sender, EventArgs e)
        {
            int idx = DataFrame.DataSet.Rows.IndexOf(row);
            int view = Convert.ToInt32(row["View"]) + 1;

            DataFrame.DataSet.Rows[idx]["View"] = view;

            WatchFilm showFilm = new WatchFilm(row);
            showFilm.Show();
        }
    }
}
