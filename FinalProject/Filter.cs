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
    public partial class Filter : Form
    {
        private DataTable table;
        private Form activeForm;
        public Filter(DataTable tb)
        {
            InitializeComponent();
            table = tb;
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            Load_Filter(table);
        }
        
        private void Load_Filter(DataTable table)
        {
            foreach (DataRow row in table.Rows) 
            {
                Film film = cv2.filmread(row);
                flowPnlFilter.Controls.Add(film);

                film.PictureBoxClick += Film_Click;
            }
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

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked event pictureBox")]
        public event EventHandler ClickInHome;
        public DataRow YourChoice;
        private void Film_Click(object sender, EventArgs e)
        {
            Film film = (Film)sender;

            string s = "Name='" + film.lbName.Text + "'";
            YourChoice = DataFrame.DataSet.Select(s)[0];

            if (this.ClickInHome != null)
                this.ClickInHome(this, e);

        }
    }
}
