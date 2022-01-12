
namespace FinalProject
{
    partial class PlayYoutube
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.pnlInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(872, 406);
            this.webBrowser.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(872, 50);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Title";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInfor
            // 
            this.pnlInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfor.AutoScroll = true;
            this.pnlInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlInfor.Controls.Add(this.lbAuthor);
            this.pnlInfor.Controls.Add(this.label1);
            this.pnlInfor.Controls.Add(this.lbTitle);
            this.pnlInfor.ForeColor = System.Drawing.Color.White;
            this.pnlInfor.Location = new System.Drawing.Point(0, 405);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(872, 104);
            this.pnlInfor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 2);
            this.label1.TabIndex = 7;
            // 
            // lbAuthor
            // 
            this.lbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lbAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(170)))), ((int)(((byte)(156)))));
            this.lbAuthor.Location = new System.Drawing.Point(0, 52);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbAuthor.Size = new System.Drawing.Size(872, 27);
            this.lbAuthor.TabIndex = 8;
            this.lbAuthor.Text = "Author";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(876, 507);
            this.Controls.Add(this.pnlInfor);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlayYoutube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayYoutube";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlayYoutube_Load);
            this.pnlInfor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAuthor;
    }
}