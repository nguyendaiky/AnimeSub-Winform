using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using Google.Apis.YouTube.v3.Data;
using System.Net;
using System.Drawing;
using System.ComponentModel;

namespace FinalProject
{
    public partial class YoutubeVideo : UserControl
    {
        public SearchResult YourChoice = null;
        public YoutubeVideo(SearchResult searchResult)
        {
            InitializeComponent();
            string title = searchResult.Snippet.Title;
            string author = searchResult.Snippet.ChannelTitle;
            Image thumbnail;

            try
            {
                byte[] imageBytes = new WebClient().DownloadData(searchResult.Snippet.Thumbnails.High.Url);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    thumbnail = Image.FromStream(ms);
                }
                Thumbnail.Image = cv2.resize_width(thumbnail, Thumbnail.Width);
            }
            catch { thumbnail = null; }
            Title.Text = title;
            Author.Text = author;

            YourChoice = searchResult;
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

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked event pictureBox")]
        public event EventHandler DownloadClick;
        public event EventHandler AddStoreClick;
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (this.DownloadClick != null)
                this.DownloadClick(this, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.AddStoreClick != null)
                this.AddStoreClick(this, e);
        }
    }
}
