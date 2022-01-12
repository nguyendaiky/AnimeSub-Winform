using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ForgetPassword : Form
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

        Random rnd = new Random();
        public int code;
        string[] strData;
        List<UserData> usersData = new List<UserData>();
        string url = Application.StartupPath + "\\User\\User.txt";
        public Home ParentForm { get; set; }

        public ForgetPassword()
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

        private void mail(string username, string receiveMail)
        {

            code = rnd.Next(123123, 999999);

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("ndk2579@gmail.com");

            message.To.Add(new MailAddress(receiveMail));
            message.Subject = "Khôi phục mật khẩu AnimeSub";
            message.Body = "Xin chào " + username + "!\nĐây là mã xác minh bạn cần dùng để đổi mật khẩu Tài khoản AnimeSub của bạn:\n" + code + "\n\nNếu bạn không yêu cầu mã này thì có thể là ai đó đang tìm cách truy cập vào tài khoản của bạn." + "\nKhông chuyển tiếp hoặc cung cấp mã này cho bất kỳ ai." + "\n\nTrân trọng!\nAnimeSub.";
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("ndk2579@gmail.com", "PassWord@147258369");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }

        private void editData(string username, string email, string oldPass, string newPass)
        {
            var tempFile = Path.GetTempFileName();
            string rm = "{\"username\": \"" + username + "\", \"email\": \"" + email + "\", \"password\": \"" + oldPass + "\"}";
            var linesToKeep = File.ReadLines(url).Where(l => l != rm);

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(url);
            File.Move(tempFile,url);
            string cr = "{\"username\": \"" + username + "\", \"email\": \"" + email + "\", \"password\": \"" + newPass + "\"}";
            using (StreamWriter sr = File.AppendText(url))
            {
                sr.WriteLine(cr);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.ParentForm.Login();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "")
            {
                lbError.Text = "Chưa nhập tên tài khoản hoặc email!";
                lbError.Visible = true;
            }
            else
            {
                bool flag = false;
                foreach (var user in usersData)
                {
                    if (txtUsername.Text == user.username && txtEmail.Text == user.email)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    lbError.Text = "Tên tài khoản hoặc email không tồn tại!";
                    lbError.Visible = true;
                }
                else
                {
                    lbError.Text = "Nhập mã xác nhận đã gửi trong mail.";
                    lbError.ForeColor = Color.Green;
                    lbError.Visible = true;
                    mail(txtUsername.Text ,txtEmail.Text);
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtNewPass.Text == "" || txtRePass.Text == "")
            {
                lbError.Text = "Chưa điền thông tin!";
                lbError.ForeColor = Color.Red;
                lbError.Visible = true;
            }
            else if (txtCode.Text != code.ToString())
            {
                lbError.Text = "Mã xác nhận không chính xác!";
                lbError.ForeColor = Color.Red;
                lbError.Visible = true;
            }
            else if (txtNewPass.Text != txtRePass.Text)
            {
                lbError.Text = "Mật khẩu không khớp!";
                lbError.ForeColor = Color.Red;
                lbError.Visible = true;
            }
            else if (txtNewPass.Text.Length < 8)
            {
                lbError.Text = "Mật khẩu phải lớn hơn 7 kí tự!";
                lbError.ForeColor = Color.Red;
                lbError.Visible = true;
            }
            else
            {
                bool flag = false;
                foreach (var user in usersData)
                {
                    if (txtUsername.Text == user.username && txtEmail.Text == user.email)
                    {
                        flag = true;
                        editData(user.username, user.email, user.password, txtRePass.Text);
                    }
                }
                if (flag)
                {
                    lbError.Text = "Khôi phục mật khẩu thành công!";
                    lbError.ForeColor = Color.Green;
                    lbError.Visible = true;
                }
                else
                {
                    lbError.Text = "Khôi phục mật khẩu thất bại!";
                    lbError.ForeColor = Color.Red;
                    lbError.Visible = true;
                }
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }
    }
}
