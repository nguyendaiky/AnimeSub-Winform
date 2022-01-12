using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Drawing;
using VideoLibrary;
using MediaToolkit;
using System.Runtime.InteropServices;

namespace FinalProject
{
    public partial class YoutubeSearch : Form
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

        public YoutubeSearch()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            using (Bitmap bm = Properties.Resources.youtube)
            {
                this.Icon = Icon.FromHandle(bm.GetHicon());
            }
        }


        private void SearchVideo(string keyword)
        {
            try
            {
                pnlSearch.Controls.Clear();
                ShowSearch(Run(keyword));
            }
            catch (AggregateException ex)
            {
                string error = "";
                foreach (var e in ex.InnerExceptions)
                {
                    error = error + "Error: " + e.Message + '\n';
                }
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<SearchResult> Run(string search)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyC4IgMQoqPKdtW7I5o4-02w1jL94Sb_7Tg",
                ApplicationName = this.GetType().ToString()
            });

            // Below is my code
            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = search;
            searchListRequest.MaxResults = 20;

            var searchListResponse = searchListRequest.Execute();

            List<SearchResult> videos = new List<SearchResult>();

            foreach (var searchResult in searchListResponse.Items)
            {
                if (searchResult.Id.Kind == "youtube#video")
                {
                    videos.Add(searchResult);
                }
            }

            return videos;
        }
        private void ShowSearch(List<SearchResult> videos)
        {
            foreach (var searchResult in videos)
            {
                YoutubeVideo video = new YoutubeVideo(searchResult);
                video.Dock = DockStyle.Top;
                pnlSearch.Controls.Add(video);
                video.ChoseClick += SearchReasult_Click;
                video.DownloadClick += DownloadVideo;
                video.AddStoreClick += AddStoreVideo;
            }
        }
        private void SearchReasult_Click(object sender, EventArgs e)
        {
            if ((YoutubeVideo)sender != null)
            {
                var vid = ((YoutubeVideo)sender).YourChoice;
                new PlayYoutube(vid.Id.VideoId, vid.Snippet.Title, vid.Snippet.ChannelTitle).Show();
            }
        }
        private void DownloadVideo(object sender, EventArgs e)
        {
            SearchResult video = ((YoutubeVideo)sender).YourChoice;
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string path  = folderDialog.SelectedPath + "\\" + video.Snippet.Title + ".mp4";
                    var ytb = YouTube.Default;
                    var vid = ytb.GetVideo("https://www.youtube.com/watch?v=" + video.Id.VideoId);
                    File.WriteAllBytes(path, vid.GetBytes());
                    MessageBox.Show(video.Snippet.Title + " Download Video Done!");
                }
            }
        }
        private void AddStoreVideo(object sender, EventArgs e)
        {
            SearchResult video = ((YoutubeVideo)sender).YourChoice;
            string url = "https://www.youtube.com/watch?v=" + video.Id.VideoId;
            if (!DataFrame.MyStore.Contains(url))
            {
                DataFrame.MyStore.Add(url);
                MessageBox.Show("Thêm '" + video.Snippet.Title + "' vào kho thành công");
            }
            else
            {
                MessageBox.Show("'" + video.Snippet.Title + "' đã có trong không của bạn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// //////////////////////////////////////////////////////////////////////////////////
        private void pctSearch_Click(object sender, EventArgs e)
        {
            SearchVideo(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
                SearchVideo(txtSearch.Text);
        }
    }
}
