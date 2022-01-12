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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login : Form
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
        public Home ParentForm { get; set; }

        public Login()
        {
            InitializeComponent();
            lbError.Visible = false;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoadData();
        }

        public void LoadData()
        {
            strData = File.ReadAllLines(url);
            foreach (string line in strData)
            {
                usersData.Add(JsonConvert.DeserializeObject<UserData>(line));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "" || this.txtPassword.Text == "")
            {
                lbError.Text = "Chưa nhập đủ thông tin đăng nhập!";
                lbError.Visible = true;
            }
            else
            {
                bool flag = false;
                foreach (var user in usersData)
                {
                    if (txtUsername.Text == user.username && txtPassword.Text == user.password)
                    {
                        flag = true;
                        UserData.currentUsername = user.username;
                        UserData.currentEmail = user.email;
                        UserData.currentPassword = user.password;
                    }
                }
                if (flag)
                {
                    this.Close();
                }
                else
                {
                    lbError.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                    lbError.Visible = true;
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.ParentForm.Register();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.ParentForm.ForgetPassword();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtUsername.Text == "" || this.txtPassword.Text == "")
                {
                    lbError.Text = "Chưa nhập đủ thông tin đăng nhập!";
                    lbError.Visible = true;
                }
                else
                {
                    bool flag = false;
                    foreach (var user in usersData)
                    {
                        if (txtUsername.Text == user.username && txtPassword.Text == user.password)
                        {
                            flag = true;
                            UserData.currentUsername = user.username;
                            UserData.currentEmail = user.email;
                            UserData.currentPassword = user.password;
                        }
                    }
                    if (flag)
                    {
                        this.Close();
                    }
                    else
                    {
                        lbError.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                        lbError.Visible = true;
                    }
                }
            }
        }
    }
}
