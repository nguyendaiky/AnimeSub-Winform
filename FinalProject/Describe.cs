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
        private Form activeForm;
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
            lbView.Text = row["View"].ToString();

        }
        private void Load_Data()
        {
            Load_Image();
            Load_Name();
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void lbWatch_Click(object sender, EventArgs e)
        {
            WatchFilm showFilm = new WatchFilm(row);
            OpenChildForm(showFilm);
        }

        //random film
        private void btnRandom_Click(object sender, EventArgs e)
        {
            int limit = DataFrame.DataSet.Rows.Count;
            Random random = new Random();

            int idx = random.Next(limit);
            DataRow random_row = DataFrame.DataSet.Rows[idx];
            OpenChildForm(new Describe(random_row));
        }
    }
}
