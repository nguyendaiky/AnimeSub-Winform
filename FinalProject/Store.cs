using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace FinalProject
{
    public partial class Store : Form
    {
        List<char> ap = new List<char>( new char[]
            {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
            'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            Load_Button(ap);
            LoadHistory();
            LoadMyStore();
        }

        private Form activeForm;
        private void OpenChildForm(Form childForm)
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

        private void Load_Button(List<char> ap)
        {
            //load all
            Button btn_all = new Button
            {
                Text = "All",
                Width = 40,
                Height = 25
            };
            btn_all.Click += LoadGrid_Click;
            flowPnlButton.Controls.Add(btn_all);
            //load 0-9
            Button btn_09 = new Button
            {
                Text = "0-9",
                Width = 40,
                Height = 25
            };
            btn_09.Click += LoadGrid_Click;
            flowPnlButton.Controls.Add(btn_09);
            foreach(char key in ap)
            {
                Button btn = new Button
                {
                    Text = key.ToString(),
                    Width = 40,
                    Height = 25
                };
                btn.Click += LoadGrid_Click;
                flowPnlButton.Controls.Add(btn);
            }
        }

        private void LoadGrid_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Text;
            gridViewLib.DataSource = tableGridView(FilterTable(s));
            ResizeGrid();
        }

        //load data
        private void ResizeGrid()
        {
            gridViewLib.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            gridViewLib.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private DataTable tableGridView(DataTable table)
        {
            int idx = 1;
            DataTable result = new DataTable();
            result.Columns.Add("STT", typeof(int));
            result.Columns.Add("*", typeof(Image));
            result.Columns.Add("Tên", typeof(string));
            result.Columns.Add("Năm", typeof(int));
            result.Columns.Add("Thể loại", typeof(string));
            result.Columns.Add("Studio", typeof(string));
            result.Columns.Add("Rating", typeof(double));
            foreach (DataRow row in table.Rows)
            {
                string name = row["NameSort"].ToString();
                int year = Convert.ToInt32(row["Season"].ToString().Split('-')[1]);
                string type = row["Type"].ToString();
                string studio = row["Studio"].ToString();
                Image img = cv2.resize_width(cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif"), 64);
                double rate = Convert.ToDouble(row["Rating"]);

                result.Rows.Add(idx, img, name, year, type, studio, rate);
                idx += 1;
            }
            return result;
        }
        private DataTable FilterTable(string s)
        {
            DataTable res = DataFrame.new_DataFilm();
            
            if (s == "0-9")
            {
                foreach (int idx in new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' })
                {
                    foreach (DataRow row in DataFrame.DataSet.Rows)
                    {
                        char alter = row["NameSort"].ToString()[0];
                        if (alter == idx)
                        {
                            res.ImportRow(row);
                        }
                    }
                }
                return res;
            }

            if (s == "All")
            {
                foreach (DataRow row in DataFrame.DataSet.Rows)
                {
                    res.ImportRow(row);
                }
                return res;
            }

            foreach (DataRow row in DataFrame.DataSet.Rows)
            {
                char alter = row["NameSort"].ToString()[0];
                if (alter == Convert.ToChar(s))
                {
                    res.ImportRow(row);
                }
            }
            return res;
        }
        private void gridViewLib_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = (DataTable)gridViewLib.DataSource;
            try
            {
                DataRow dr = table.Rows[e.RowIndex];
                DataRow row = DataFrame.DataSet.Select(string.Format("NameSort ='{0}'", dr["Tên"].ToString().Replace("'", "''")))[0];
                OpenChildForm(new Describe(row));
            }
            catch { }
        }

        //Lịch sử xem phim
        private void LoadHistory()
        {
            foreach(string s in DataFrame.History)
            {
                if (s != "")
                {
                    DataRow row = DataFrame.DataSet.Select("Name='" + s + "'")[0];
                    Film hisFilm = cv2.filmread(row);
                    flowPnlHistory.Controls.Add(hisFilm);
                    hisFilm.PictureBoxClick += HisClick;
                }
            }
        }
        private void HisClick(object sender, EventArgs e)
        {
            Film film = (Film)sender;
            DataRow row = DataFrame.DataSet.Select("Name='" + film.lbName.Text + "'")[0];
            OpenChildForm(new Describe(row));
        }

        //MyStore kho của bạn
        private Video getVideoFromUrl(string url)
        {
            string id = url.Split('=')[1];
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyC4IgMQoqPKdtW7I5o4-02w1jL94Sb_7Tg",
                ApplicationName = this.GetType().ToString()
            });

            var FindbyID = youtubeService.Videos.List("snippet,status");
            FindbyID.Id = id;
            FindbyID.MaxResults = 1;
            var searchListResponse = FindbyID.Execute();
            Video vid = searchListResponse.Items[0];

            return vid;            
        }
        private void LoadMyStore()
        {
            foreach (string s in DataFrame.MyStore)
            {
                if (s != "")
                {
                    if (s.Contains("youtube.com"))
                    {
                        YoutubeSave vid = new YoutubeSave(getVideoFromUrl(s));
                        pnlYoutube.Controls.Add(vid);
                        vid.Dock = DockStyle.Top;
                        vid.ChoseClick += ClickYT;
                        vid.Remove_Click += RemoveFilm;
                    }
                    else
                    {
                        DataRow row = DataFrame.DataSet.Select("Name='" + s + "'")[0];
                        Film hisFilm = cv2.filmread(row);
                        flowPnlMyStore.Controls.Add(hisFilm);
                        hisFilm.PictureBoxClick += ClickFilm;
                        hisFilm.pctRemove.Visible = true;
                        hisFilm.Remove_Click += RemoveFilm;
                    }
                }
            }
        }

        private void ClickFilm(object sender, EventArgs e)
        {
            Film film = (Film)sender;
            DataRow row = DataFrame.DataSet.Select("Name='" + film.lbName.Text + "'")[0];
            OpenChildForm(new Describe(row));
        }
        private void ClickYT(object sender, EventArgs e)
        {
            YoutubeSave ytsave = (YoutubeSave)sender;
            PlayYoutube play = new PlayYoutube(ytsave.YourChoice.Id,
                ytsave.YourChoice.Snippet.Title, ytsave.YourChoice.Snippet.ChannelTitle);
            play.Show();
        }
        //xóa film khỏi kho
        private void RemoveFilm(object sender, EventArgs e)
        {
            string remove;
            try
            {
                var item = (Film)sender;
                remove = item.lbName.Text;
            }
            catch
            {
                var item = (YoutubeSave)sender;
                remove = "https://www.youtube.com/watch?v=" + item.YourChoice.Id;
            }
            DataFrame.MyStore.Remove(remove);
            flowPnlMyStore.Controls.Clear();
            pnlYoutube.Controls.Clear();
            LoadMyStore();
        }
    }
}
