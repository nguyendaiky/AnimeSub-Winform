using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Drawing;

namespace FinalProject
{
    class UserData
    {
        public static string currentUsername = "";
        public static string currentEmail = "";
        public static string currentPassword = "";
        public static Image Avatar = null;
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        List<DataRow> StoreFilm = new List<DataRow>();
        List<SearchResult> StoreYoutube = new List<SearchResult>();
    }
}
