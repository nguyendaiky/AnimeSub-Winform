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
        private string url;
        private string ID;
        public PlayYoutube(string id, string title, string channel)
        {
            InitializeComponent();
            using (Bitmap bm = Properties.Resources.youtube)
            {
                this.Icon = Icon.FromHandle(bm.GetHicon());
            }
            url = "https://www.youtube.com/embed" + id;
            ID = id;
            LoadInformation(title, channel);
        }

        private void PlayYoutube_Load(object sender, EventArgs e)
        {
            string emded = "<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"100%\" height=\"" + webBrowser.Height + "\" src=\"https://www.youtube.com/embed/{0}?autoplay=1\"" +
                    "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                    "</body></html>";
            this.webBrowser.DocumentText = string.Format(emded, ID);

        }

        private void LoadInformation(string title, string channel)
        {
            lbTitle.Text = title;
            lbAuthor.Text = channel;
        }
    }  
}
