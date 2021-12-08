using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FinalProject
{
    public partial class FrmFilter : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public FrmFilter(List<string> filmType, List<string> Studio, Tuple<List<string>, List<string>> Season_Year)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Load_Button(filmType, flowPnlType);
            Load_Button(Studio, flowPnlStudio);
            Load_Button(Season_Year.Item1, flowPnlSeason);
            Load_Button(Season_Year.Item2, flowPnlYear);
        }
        private void Load_Button(List<string> lstType, FlowLayoutPanel pnl)
        {
            foreach (string strType in lstType)
            {
                CheckBox checkBox = new CheckBox()
                {
                    Text = strType
                };
                pnl.Controls.Add(checkBox);
            }
        }

        //output
        public List<string> lstChoseType = new List<string>();
        public List<string> lstChoseStudio = new List<string>();
        public List<string> lstChoseSeason = new List<string>();
        public List<string> lstChoseYear = new List<string>();
        private List<string> getChose(FlowLayoutPanel pnl)
        {
            List<string> result = new List<string>();
            foreach (CheckBox checkBox in pnl.Controls)
            {
                if (checkBox.Checked)
                    result.Add(checkBox.Text);
            }
            return result;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            lstChoseType = getChose(flowPnlType);
            lstChoseStudio = getChose(flowPnlStudio);
            lstChoseSeason = getChose(flowPnlSeason);
            lstChoseYear = getChose(flowPnlYear);
            this.Close();
        }
    }
}
