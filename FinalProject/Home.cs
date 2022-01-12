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

namespace FinalProject
{
    public partial class Home : Form
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

        private Form activeForm;
        public Home()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Load_Data(DataFrame.DataSet);//load dataset
            Login(); // login
            LoadTopAnime();//load top anime
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Home_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void Login()
        {
            Login loginFrm = new Login();
            loginFrm.ParentForm = this;
            loginFrm.ShowDialog();
            // avatar when login
;           try
            {
                string path_avatar = Application.StartupPath + "\\User\\" + UserData.currentUsername + ".jfif";
                UserData.Avatar = cv2.resize(cv2.imread(path_avatar), new Size(pctAvatar.Width, pctAvatar.Height));
                pctAvatar.Image = UserData.Avatar;
            }
            catch { pctAvatar.Image = cv2.resize(Properties.Resources.avarta, new Size(pctAvatar.Width, pctAvatar.Height)); }
        }

        public void Register()
        {
            Register registerFrm = new Register();
            registerFrm.ParentForm = this;
            registerFrm.ShowDialog();
        }

        public void ForgetPassword()
        {
            ForgetPassword forgetFrm = new ForgetPassword();
            forgetFrm.ParentForm = this;
            forgetFrm.ShowDialog();
        }

        //about form home
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        Size original;
        private void Home_Load(object sender, EventArgs e)
        {
            original = this.Size;
            int limit = DataFrame.DataSet.Rows.Count;
            Random random = new Random();

            int idx = random.Next(limit);
            DataRow random_row = DataFrame.DataSet.Rows[idx];
            Load_Preview(random_row);

            pnlPreview.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlPreview.Width, pnlPreview.Height, 20, 20));
            flownlListFilm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flownlListFilm.Width, flownlListFilm.Height, 20, 20));

            DataFrame.History = DataFrame.ReadHistory();//load history
            DataFrame.MyStore = DataFrame.ReadMyStore();//load my store
            ResizeGrid();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataFrame.WriteExcel(Application.StartupPath + "\\Data.xlsx", DataFrame.DataSet);
            DataFrame.WriteHistory();
            DataFrame.WriteMyStore();
        }

        private void pnlTile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
                if (this.Location.Y <= 0)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.Size = original;
                }

                // Drag to side to split screen
                if (this.Location.X <= 0)
                {
                    this.Location = new Point(0, 0);
                    this.Size = new Size(SystemInformation.WorkingArea.Width / 2, SystemInformation.WorkingArea.Height);
                }
                else if (this.Location.X >= SystemInformation.WorkingArea.Width / 2)
                {
                    this.Location = new Point(SystemInformation.WorkingArea.Width / 2, 0);
                    this.Size = new Size(SystemInformation.WorkingArea.Width / 2, SystemInformation.WorkingArea.Height);
                }
                else
                {
                    this.Size = original;
                }
            }
        }

        private void pnlTile_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Load_Preview(DataRow row)
        {
            Image img;
            try
            {
                img = cv2.resize_width(cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\preview.jfif"), pnlPreview.Width);
            }
            catch
            {
                img = cv2.resize_width(cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif"), pnlPreview.Width);
            }
            pnlPreview.BackgroundImage = img;
            lbName.Text = row["Name"].ToString();
            lbView.Text = string.Format("{0:N}", Convert.ToInt32(row["View"])).Replace(".00", "");
            lbRating.Text = Math.Round(Convert.ToDouble(row["Rating"]), 1).ToString();
            lbNumEp.Text = row["NumEp"].ToString() + " Tập";
            lbNumMoive.Text = row["NumMovie"].ToString() + " Tập";
        }


        // load film 
        private void Load_Data(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                Film film = cv2.filmread(row);
                flownlListFilm.Controls.Add(film);

                film.PictureBoxClick += Film_Click;
                film.pctMouseHover += Film_MouseHover;
            }
        }
        private void RestPnlFilm(DataTable table)
        {
            flownlListFilm.Controls.Clear();
            Load_Data(table);
        }

        private void OpenChildForm(Form childForm, Panel pnl)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl.Controls.Add(childForm);
            pnl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Film_Click(object sender, EventArgs e)
        {
            Film film = (Film)sender;
            string s = "Name='" + film.lbName.Text + "'";
            DataRow row = DataFrame.DataSet.Select(s)[0];
            OpenChildForm(new Describe(row), pnlLoadAll);
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            string s = "Name='" + lbName.Text + "'";
            DataRow row = DataFrame.DataSet.Select(s)[0];
            OpenChildForm(new Describe(row), pnlLoadAll);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BringToFront();
            if (activeForm != null)
            {
                activeForm.Close();
                RestPnlFilm(DataFrame.DataSet);
            }
        }

        //random film
        private void btnRandom_Click(object sender, EventArgs e)
        {
            int limit = DataFrame.DataSet.Rows.Count;
            Random random = new Random();

            int idx = random.Next(limit);
            DataRow random_row = DataFrame.DataSet.Rows[idx];
            OpenChildForm(new Describe(random_row), pnlLoadAll);
        }

        //preview
        private void Film_MouseHover(object sender, EventArgs e)
        {
            Film film = (Film)sender;
            string s = "Name='" + film.lbName.Text + "'";
            DataRow drow = DataFrame.DataSet.Select(s)[0];

            Load_Preview(drow);
        }

        //store film
        private void btnStore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Store(), pnlLoadAll);
        }

        //User
        private void pctAvatar_Click(object sender, EventArgs e)
        {
            User userFrm = new User();
            this.Visible = false;
            userFrm.ShowDialog();
            this.Visible = true;

            string path_avatar = userFrm.path_avatar;
            string path_save = Application.StartupPath + "\\User\\" + UserData.currentUsername + ".jfif";
            SaveAvatar(path_avatar, path_save);
        }
        private void SaveAvatar(string path_avatar, string path_save)
        {
            if (path_avatar != "")
            {
                if (File.Exists(path_save))
                {
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    File.Delete(path_save);
                    File.Copy(path_avatar, path_save);
                }
                else
                {
                    File.Copy(path_avatar, path_save);
                }
                UserData.Avatar = cv2.resize(cv2.imread(path_avatar), new Size(pctAvatar.Width, pctAvatar.Height));
                pctAvatar.Image = UserData.Avatar;
            }
        }

        //search and filter anime
        private void OpenFilter(DataTable table)
        {
            Filter frmFilter = new Filter(table);
            OpenChildForm(frmFilter, pnlAnime);
            frmFilter.ClickInHome += ChoseFilm;
        }

        private DataTable TakeTableFromFilter(DataTable table, List<List<string>> filter)
        {
            DataTable result = DataFrame.new_DataFilm();
            foreach (DataRow row in table.Rows)
            {
                string[] lstSeason = row["Season"].ToString().Split('-');
                string season = lstSeason[0].Trim();
                string year = lstSeason[1].Trim();
                if (filter[0].All(row["Type"].ToString().Contains) && filter[1].All(row["Studio"].ToString().Contains)
                    && filter[2].All(season.Contains) && filter[3].All(year.Contains))
                {
                    DataRow[] dr = result.Select("Name='" + row["Name"].ToString() + "'");
                    if (dr.Length == 0)
                        result.ImportRow(row);
                }
            }

            return result;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<string> TypeFilm = DataFrame.getDataFromCol(DataFrame.DataSet, "Type");
            TypeFilm.RemoveAt(26);
            List<string> Studio = DataFrame.getDataFromCol(DataFrame.DataSet, "Studio");
            Tuple<List<string>, List<string>> Season_Year = DataFrame.getSplitSeaseon(DataFrame.DataSet);
            FrmFilter chsType = new FrmFilter(TypeFilm, Studio, Season_Year);
            chsType.ShowDialog();
            DataTable lstChose = TakeTableFromFilter(DataFrame.DataSet, new List<List<string>>()
            {
                chsType.lstChoseType,
                chsType.lstChoseStudio,
                chsType.lstChoseSeason,
                chsType.lstChoseYear
            });

            OpenFilter(lstChose);
        }

        private void pctSearch_Click(object sender, EventArgs e)
        {
            DataTable table = SearchTable(txtSearch.Text);
            OpenFilter(table);
        }

        private DataTable SearchTable(string s)
        {
            DataTable res = DataFrame.new_DataFilm();

            foreach (DataRow row in DataFrame.DataSet.Rows)
            {
                string name = row["Name"].ToString();
                if (name.Contains(s))
                    res.ImportRow(row);
            }

            return res;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable table = SearchTable(txtSearch.Text);
                Filter frmFilter = new Filter(table);
                frmFilter.ClickInHome += ChoseFilm;
                OpenFilter(table);
            }
        }

        private void ChoseFilm(object sender, EventArgs e)
        {
            Filter frmFilter = (Filter)sender;
            OpenChildForm(new Describe(frmFilter.YourChoice), pnlLoadAll);
        }

        // youtube

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            YoutubeSearch frmSearchY = new YoutubeSearch();
            frmSearchY.ShowDialog();
        }

        private void pnlPreview_ClientSizeChanged(object sender, EventArgs e)
        {
            pnlPreview.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlPreview.Width, pnlPreview.Height, 20, 20));
        }

        private void flownlListFilm_ClientSizeChanged(object sender, EventArgs e)
        {
            flownlListFilm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flownlListFilm.Width, flownlListFilm.Height, 20, 20));
        }

        //Top anime
        private void LoadTopAnime()
        {
            DataView top = DataFrame.DataSet.DefaultView;
            top.Sort = "View desc";
            DataTable sorted = top.ToTable();

            DataTable res = new DataTable();
            res.Columns.Add("Tên", typeof(string));
            res.Columns.Add("Lượt xem", typeof(int));

            for(int idx = 0; idx < 10; idx++)
            {
                DataRow row = res.NewRow();
                row["Tên"] = sorted.Rows[idx]["Name"].ToString();
                row["Lượt xem"] = Convert.ToInt32(sorted.Rows[idx]["View"]);
                res.Rows.Add(row);
            }
            gridViewTop.DataSource = res;
        }
        private void ResizeGrid()
        {
            gridViewTop.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            gridViewTop.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void gridViewTop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = (DataTable)gridViewTop.DataSource;
            try
            {
                DataRow dr = table.Rows[e.RowIndex];
                DataRow row = DataFrame.DataSet.Select(string.Format("Name ='{0}'", dr["Tên"].ToString().Replace("'", "''")))[0];
                OpenChildForm(new Describe(row), pnlLoadAll);
            }
            catch { }
        }
    }
}
