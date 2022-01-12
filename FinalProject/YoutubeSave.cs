using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using VideoLibrary;

namespace FinalProject
{
    public partial class YoutubeSave : UserControl
    {
        public Google.Apis.YouTube.v3.Data.Video YourChoice;
        public YoutubeSave(Google.Apis.YouTube.v3.Data.Video vid)
        {
            InitializeComponent();
            string title = vid.Snippet.Title;
            string author = vid.Snippet.ChannelTitle;
            Image thumbnail;

            try
            {
                byte[] imageBytes = new WebClient().DownloadData(vid.Snippet.Thumbnails.High.Url);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    thumbnail = Image.FromStream(ms);
                }
                Thumbnail.Image = cv2.resize_width(thumbnail, Thumbnail.Width);
            }
            catch { thumbnail = null; }
            Title.Text = title;
            Author.Text = author;
            YourChoice = vid;
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked event pictureBox")]
        public event EventHandler ChoseClick;
        private void Mouse_Click(object sender, EventArgs e)
        {
            if (this.ChoseClick != null)
                this.ChoseClick(this, e);
        }

        public event EventHandler Remove_Click;
        private void pctRemove_Click(object sender, EventArgs e)
        {
            if (this.Remove_Click != null)
                this.Remove_Click(this, e);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string id = YourChoice.Id;
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = folderDialog.SelectedPath + "\\" + YourChoice.Snippet.Title + ".mp4";
                    var ytb = YouTube.Default;
                    var vid = ytb.GetVideo("https://www.youtube.com/watch?v=" + id);
                    File.WriteAllBytes(path, vid.GetBytes());
                    MessageBox.Show(YourChoice.Snippet.Title + " Download Video Done!");
                }
            }
        }
    }
}
