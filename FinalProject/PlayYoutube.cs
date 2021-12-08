using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.YouTube.v3.Data;
using System.Net;
using System.Text.RegularExpressions;

namespace FinalProject
{
    public partial class PlayYoutube : Form
    {
        private SearchResult video;
        private string url;
        public PlayYoutube(SearchResult vid)
        {
            InitializeComponent();
            using (Bitmap bm = Properties.Resources.youtube)
            {
                this.Icon = Icon.FromHandle(bm.GetHicon());
            }
            video = vid;
            url = "https://www.youtube.com/embed" + vid.Id.VideoId;
        }

        private void PlayYoutube_Load(object sender, EventArgs e)
        {
            string emded = "<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"100%\" height=\"" + webBrowser.Height + "\" src=\"https://www.youtube.com/embed/{0}?autoplay=1\"" +
                    "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                    "</body></html>";
            this.webBrowser.DocumentText = string.Format(emded, video.Id.VideoId);

            LoadInformation();
        }

        private void LoadInformation()
        {
            lbTitle.Text = video.Snippet.Title;
            
        }
    }  
}
