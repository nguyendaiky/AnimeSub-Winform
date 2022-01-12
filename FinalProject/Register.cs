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
    public partial class Register : Form
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

        public Register()
        {
            InitializeComponent();
            lbError.Visible = false;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            strData = File.ReadAllLines(url);
            foreach (string line in strData)
            {
                usersData.Add(JsonConvert.DeserializeObject<UserData>(line));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "" || this.txtEmail.Text == "" || this.txtPassword.Text == "")
            {
                lbError.Text = "Chưa nhập đủ thông tin!";
                lbError.Visible = true;
            }
            else if (txtPassword.Text != txtRePass.Text)
            {
                lbError.Text = "Mật khẩu không khớp!";
                lbError.Visible = true;
            }
            else if (txtPassword.Text.Length < 8)
            {
                lbError.Text = "Mật khẩu phải lớn hơn 7 kí tự!";
                lbError.Visible = true;
            }
            else
            {
                string pattern = "[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+";
                if (Regex.IsMatch(txtEmail.Text,pattern))
                {
                    bool flag = false;
                    foreach (var user in usersData)
                    {
                        if (txtUsername.Text == user.username || txtEmail.Text == user.email)
                        {
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        string data = "{\"username\": \"" + txtUsername.Text + "\", \"email\": \"" + txtEmail.Text + "\", \"password\": \"" + txtPassword.Text + "\"}";
                        using (StreamWriter sr = File.AppendText(url))
                        {
                            sr.WriteLine(data);
                        }
                        this.Close();
                        this.ParentForm.Login();
                    }
                    else
                    {
                        lbError.Text = "Tài khoản đã tồn tại!";
                        lbError.Visible = true;
                    }
                }
                else
                {
                    lbError.Text = "Email không đúng định dạng!";
                    lbError.Visible = true;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.ParentForm.Login();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }
    }
}
