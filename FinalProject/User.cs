using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class User : Form
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

        string[] strData;
        List<UserData> usersData = new List<UserData>();
        string url = Application.StartupPath + "\\User\\User.txt";

        public User()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlChangePass.Visible = false;
            lbError.Visible = false;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 5, pictureBox1.Height - 5);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            lbUsername.Text = UserData.currentUsername;
            txtEmail.Text = UserData.currentEmail;
            strData = File.ReadAllLines(url);
            foreach (string line in strData)
            {
                usersData.Add(JsonConvert.DeserializeObject<UserData>(line));
            }

            try {
                string path_save = Application.StartupPath + "\\User\\" + UserData.currentUsername + ".jfif";
                UserData.Avatar = cv2.resize(cv2.imread(path_save), new Size(pictureBox1.Width, pictureBox1.Height));    
                pictureBox1.Image = UserData.Avatar;
            }
            catch { }
        }

        private void editData(string username, string email, string oldPass, string newPass)
        {
            var tempFile = Path.GetTempFileName();
            string rm = "{\"username\": \"" + username + "\", \"email\": \"" + email + "\", \"password\": \"" + oldPass + "\"}";
            var linesToKeep = File.ReadLines(url).Where(l => l != rm);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(url);
            File.Move(tempFile, url);
            string cr = "{\"username\": \"" + username + "\", \"email\": \"" + email + "\", \"password\": \"" + newPass + "\"}";
            using (StreamWriter sr = File.AppendText(url))
            {
                sr.WriteLine(cr);
            }
        }

        public string path_avatar = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = cv2.resize(cv2.imread(open.FileName), new Size(pictureBox1.Width, pictureBox1.Height));
                path_avatar = open.FileName;
                MessageBox.Show("Thay đổi ảnh đại diện thành công");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != UserData.currentEmail)
            {
                string pattern = "[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    bool flagEmail = false;
                    foreach (var user in usersData)
                    {
                        if (txtEmail.Text == user.email)
                        {
                            flagEmail = true;
                        }
                    }
                    if (!flagEmail)
                    {
                        var tempFile = Path.GetTempFileName();
                        string rm = "{\"username\": \"" + UserData.currentUsername + "\", \"email\": \"" + UserData.currentEmail + "\", \"password\": \"" + UserData.currentPassword + "\"}";
                        var linesToKeep = File.ReadLines(url).Where(l => l != rm);

                        File.WriteAllLines(tempFile, linesToKeep);

                        File.Delete(url);
                        File.Move(tempFile, url);
                        string cr = "{\"username\": \"" + UserData.currentUsername + "\", \"email\": \"" + txtEmail.Text + "\", \"password\": \"" + UserData.currentPassword + "\"}";
                        using (StreamWriter sr = File.AppendText(url))
                        {
                            sr.WriteLine(cr);
                        }
                        UserData.currentEmail = txtEmail.Text;
                        lbError.Text = "Cập nhật thông tin thành công!";
                        lbError.Visible = true;
                        lbError.ForeColor = Color.Green;
                    }
                    else if (flagEmail)
                    {
                        lbError.Text = "Email đã tồn tại!";
                        lbError.Visible = true;
                        lbError.ForeColor = Color.Red;

                    }
                }
                else
                {
                    lbError.Text = "Email không đúng định dạng!";
                    lbError.Visible = true;
                    lbError.ForeColor = Color.Red;

                }
            }
            else
            {
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlChangePass.Visible = true;
            txtOldPass.Text = "";
            txtNewPass.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text != UserData.currentPassword)
            {
                lbError.Text = "Mật khẩu cũ không đúng!";
                lbError.Visible = true;
                lbError.ForeColor = Color.Red;
                pnlChangePass.Visible = false;
            }
            else if (txtNewPass.Text == "")
            {
                lbError.Text = "Chưa nhập mật khẩu mới!";
                lbError.Visible = true;
                lbError.ForeColor = Color.Red;
                pnlChangePass.Visible = false;
            }
            else
            {
                editData(UserData.currentUsername, UserData.currentEmail, UserData.currentPassword, txtNewPass.Text);
                UserData.currentPassword = txtNewPass.Text;
                lbError.Text = "Đổi mật khẩu thành công!";
                lbError.Visible = true;
                lbError.ForeColor = Color.Green;
                pnlChangePass.Visible = false;
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }
    }
}
