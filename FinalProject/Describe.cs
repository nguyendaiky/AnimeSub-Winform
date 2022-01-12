using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace FinalProject
{
    public partial class Describe : Form
    {
        DataRow row;
        public Describe(DataRow dr)
        {
            InitializeComponent();
            row = dr;
        }

        private void Describe_Load(object sender, EventArgs e)
        {
            Load_Data();
            Load_Comment();
            //curUser
            try
            {
                pctAvatar.Image = cv2.resize(UserData.Avatar, new Size(pctAvatar.Width, pctAvatar.Height));
            }
            catch
            {
                pctAvatar.Image = cv2.resize(Properties.Resources.avarta, new Size(pctAvatar.Width, pctAvatar.Height));
            }
            lbUserName.Text = UserData.currentUsername;
        }

        private void Load_Image()
        {
            Image preview;
            Image img = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif");
            try
            {
                preview = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\preview.jfif");
            }
            catch
            {
                preview = cv2.imread(Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\image.jfif");
            }
            preview = cv2.resize_width(preview, pnlPreview.Width);
            pnlPreview.BackgroundImage = preview;
            Image resized = cv2.resize(img, new Size(pctImage.Width, pctImage.Height));
            pctImage.Image = resized;
        }
        private void Load_Name()
        {
            lbName.Text = row["Name"].ToString();
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Describe.txt";
            string s = File.ReadAllText(path);
            lbDescribe.Text = s;

            lbType.Text = row["Type"].ToString();
            lbDirector.Text = row["Director"].ToString();
            lbStudio.Text = row["Studio"].ToString();
            lbSeason.Text = row["Season"].ToString();
            lbView.Text = string.Format("{0:N}", Convert.ToInt32(row["View"])).Replace(".00", "");
            lbNumEp.Text = row["NumEp"].ToString() + " Tập";
            lbNumMoive.Text = row["NumMovie"].ToString() + " Tập";
        }
        private void Load_Data()
        {
            Load_Image();
            Load_Name();
            LoadStar(Convert.ToDouble(row["Rating"]).ToString(), row["NumRating"].ToString());
            LoadStarImage();
            FileRate();
        }

        private void lbWatch_Click(object sender, EventArgs e)
        {
            //add to data history
            DataFrame.History.Add(lbName.Text)
;           
            //load form
            int idx = DataFrame.DataSet.Rows.IndexOf(row);
            int view = Convert.ToInt32(row["View"]) + 1;

            DataFrame.DataSet.Rows[idx]["View"] = view;

            WatchFilm showFilm = new WatchFilm(row);
            showFilm.Show();
        }
        //comments film
        private void Load_Comment()
        {
            //load comment
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Comments.txt";
            if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine();
                }
            }
            List<string> data = File.ReadAllLines(path).OfType<string>().ToList(); ;
            data.Reverse();
            foreach (var line in data)
            {
                if (line != "")
                {
                    try
                    {
                        Comment cmt = new Comment(line)
                        {
                            Dock = DockStyle.Top,
                        };
                        this.Controls.Add(cmt);
                        cmt.BringToFront();
                    }
                    catch { }
                }
            }
        }

        private void ResetCmt()
        {
            foreach(Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Comment))
                {
                    ctrl.Hide();
                }
            }
        }

        private void txtWriteCmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Comments.txt";
                string data = "{\"username\": \"" + lbUserName.Text + "\", \"cmt\": \"" + txtWriteCmt.Text + "\"}";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(data);
                }
                ResetCmt();
                Load_Comment();
                txtWriteCmt.Text = "";
            }
        }

        //star
        List<string> dataRate = new List<string>();
        private void FileRate()
        {
            string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
            if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine();
                }
            }
            string s = File.ReadAllText(path).Trim();
            dataRate = s.Split('\n').OfType<string>().ToList();
        }

        private void LoadStar(string rating, string num)
        {
            double review = Convert.ToDouble(rating);
            review = Math.Round(review, 1);
            lbStar.Text = review.ToString();
            lbNumRating.Text = "Phim được đánh giá " + review.ToString() + "/10 từ " + num + " người";
        }
        private void LoadStarImage()
        {
            pctStar1.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar2.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar3.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar4.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar5.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar6.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar7.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar8.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
            pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
        }

        private void pctStar1_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 1.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());

                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar2_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 2.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar3_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 3.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar4_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 4.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar5_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 5.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar6_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 6.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar7_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 7.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar8_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 8.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar9_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.white_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 9.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        private void pctStar10_Click(object sender, EventArgs e)
        {
            if (!dataRate.Contains(UserData.currentUsername))
            {
                pctStar1.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar2.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar3.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar4.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar5.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar6.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar7.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar8.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar9.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                pctStar10.Image = cv2.resize(Properties.Resources.yellow_star, new Size(20, 20));
                //data
                double ratingAll = Convert.ToDouble(row["Rating"]) * Convert.ToDouble(row["NumRating"]);
                double newRating = (ratingAll + 10.0) / (Convert.ToDouble(row["NumRating"]) + 1.0);
                //change data
                int idx = DataFrame.DataSet.Rows.IndexOf(row);
                DataFrame.DataSet.Rows[idx]["Rating"] = Math.Round(newRating, 1);
                DataFrame.DataSet.Rows[idx]["NumRating"] = Convert.ToInt32(row["NumRating"]) + 1;
                LoadStar(newRating.ToString(), (Convert.ToInt32(row["NumRating"])).ToString());
                string path = Application.StartupPath + "\\View\\" + row["Name"].ToString() + "\\Rate.txt";
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(UserData.currentUsername);
                    dataRate.Add(UserData.currentUsername);
                }
            }
        }

        // add to my store
        private void btnAddStore_Click(object sender, EventArgs e)
        {
            if (!DataFrame.MyStore.Contains(lbName.Text))
            {
                DataFrame.MyStore.Add(lbName.Text);
                MessageBox.Show("Thêm '" + lbName.Text + "' vào kho thành công");
            }
            else
            {
                MessageBox.Show("'" + lbName.Text + "' đã có trong kho của bạn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
