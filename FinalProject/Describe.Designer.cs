
namespace FinalProject
{
    partial class Describe
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
            this.pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            this.lbWatch = new System.Windows.Forms.Label();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlDescribe = new Guna.UI2.WinForms.Guna2Panel();
            this.lbDescribe = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbView = new System.Windows.Forms.Label();
            this.lbStar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbStudio = new System.Windows.Forms.Label();
            this.lbSeason = new System.Windows.Forms.Label();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.pnlDescribe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPreview
            // 
            this.pnlPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlPreview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPreview.Controls.Add(this.lbWatch);
            this.pnlPreview.Controls.Add(this.lbName);
            this.pnlPreview.Controls.Add(this.pctImage);
            this.pnlPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlPreview.Location = new System.Drawing.Point(12, 12);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.ShadowDecoration.Parent = this.pnlPreview;
            this.pnlPreview.Size = new System.Drawing.Size(685, 286);
            this.pnlPreview.TabIndex = 0;
            // 
            // lbWatch
            // 
            this.lbWatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.lbWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbWatch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWatch.Location = new System.Drawing.Point(29, 144);
            this.lbWatch.Name = "lbWatch";
            this.lbWatch.Size = new System.Drawing.Size(150, 28);
            this.lbWatch.TabIndex = 4;
            this.lbWatch.Text = "Xem phim";
            this.lbWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWatch.Click += new System.EventHandler(this.lbWatch_Click);
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(231)))), ((int)(((byte)(69)))));
            this.lbName.Location = new System.Drawing.Point(200, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 33);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // pctImage
            // 
            this.pctImage.BorderRadius = 5;
            this.pctImage.ImageRotate = 0F;
            this.pctImage.Location = new System.Drawing.Point(29, 11);
            this.pctImage.Name = "pctImage";
            this.pctImage.ShadowDecoration.Parent = this.pctImage;
            this.pctImage.Size = new System.Drawing.Size(150, 200);
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            // 
            // pnlDescribe
            // 
            this.pnlDescribe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDescribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.pnlDescribe.Controls.Add(this.lbDescribe);
            this.pnlDescribe.Controls.Add(this.label10);
            this.pnlDescribe.Controls.Add(this.label5);
            this.pnlDescribe.Controls.Add(this.pictureBox1);
            this.pnlDescribe.Controls.Add(this.lbView);
            this.pnlDescribe.Controls.Add(this.lbStar);
            this.pnlDescribe.Controls.Add(this.label7);
            this.pnlDescribe.Controls.Add(this.label9);
            this.pnlDescribe.Controls.Add(this.label3);
            this.pnlDescribe.Controls.Add(this.lbSeason);
            this.pnlDescribe.Controls.Add(this.lbStudio);
            this.pnlDescribe.Controls.Add(this.lbType);
            this.pnlDescribe.Controls.Add(this.lbDirector);
            this.pnlDescribe.Controls.Add(this.label2);
            this.pnlDescribe.Controls.Add(this.label8);
            this.pnlDescribe.Controls.Add(this.label1);
            this.pnlDescribe.Location = new System.Drawing.Point(12, 301);
            this.pnlDescribe.Name = "pnlDescribe";
            this.pnlDescribe.ShadowDecoration.Parent = this.pnlDescribe;
            this.pnlDescribe.Size = new System.Drawing.Size(685, 211);
            this.pnlDescribe.TabIndex = 2;
            // 
            // lbDescribe
            // 
            this.lbDescribe.AllowDrop = true;
            this.lbDescribe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescribe.BackColor = System.Drawing.Color.Transparent;
            this.lbDescribe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescribe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDescribe.Location = new System.Drawing.Point(35, 182);
            this.lbDescribe.Name = "lbDescribe";
            this.lbDescribe.Size = new System.Drawing.Size(630, 29);
            this.lbDescribe.TabIndex = 5;
            this.lbDescribe.Text = "Describe";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(459, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Season:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(459, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lượt xem:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.star;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(191, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 19);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbView
            // 
            this.lbView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbView.AutoSize = true;
            this.lbView.BackColor = System.Drawing.Color.Transparent;
            this.lbView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbView.Location = new System.Drawing.Point(545, 46);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(17, 19);
            this.lbView.TabIndex = 3;
            this.lbView.Text = "0";
            // 
            // lbStar
            // 
            this.lbStar.AutoSize = true;
            this.lbStar.BackColor = System.Drawing.Color.Transparent;
            this.lbStar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStar.ForeColor = System.Drawing.Color.Gold;
            this.lbStar.Location = new System.Drawing.Point(156, 46);
            this.lbStar.Name = "lbStar";
            this.lbStar.Size = new System.Drawing.Size(29, 19);
            this.lbStar.TabIndex = 3;
            this.lbStar.Text = "0.0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(10, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mô tả:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(459, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Studio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đạo diễn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thể loại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(10, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thông tin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đánh giá:";
            // 
            // lbDirector
            // 
            this.lbDirector.AutoSize = true;
            this.lbDirector.BackColor = System.Drawing.Color.Transparent;
            this.lbDirector.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirector.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDirector.Location = new System.Drawing.Point(115, 111);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(59, 19);
            this.lbDirector.TabIndex = 4;
            this.lbDirector.Text = "Director";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbType.Location = new System.Drawing.Point(115, 79);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(39, 19);
            this.lbType.TabIndex = 4;
            this.lbType.Text = "Type";
            // 
            // lbStudio
            // 
            this.lbStudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStudio.AutoSize = true;
            this.lbStudio.BackColor = System.Drawing.Color.Transparent;
            this.lbStudio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbStudio.Location = new System.Drawing.Point(523, 79);
            this.lbStudio.Name = "lbStudio";
            this.lbStudio.Size = new System.Drawing.Size(48, 19);
            this.lbStudio.TabIndex = 4;
            this.lbStudio.Text = "Studio";
            // 
            // lbSeason
            // 
            this.lbSeason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSeason.AutoSize = true;
            this.lbSeason.BackColor = System.Drawing.Color.Transparent;
            this.lbSeason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeason.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSeason.Location = new System.Drawing.Point(527, 111);
            this.lbSeason.Name = "lbSeason";
            this.lbSeason.Size = new System.Drawing.Size(53, 19);
            this.lbSeason.TabIndex = 4;
            this.lbSeason.Text = "Season";
            // 
            // Describe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 517);
            this.Controls.Add(this.pnlDescribe);
            this.Controls.Add(this.pnlPreview);
            this.Name = "Describe";
            this.Text = "Describle";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Describe_Load);
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.pnlDescribe.ResumeLayout(false);
            this.pnlDescribe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel pnlDescribe;
        private Guna.UI2.WinForms.Guna2PictureBox pctImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private System.Windows.Forms.Label lbWatch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbStar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbView;
        private System.Windows.Forms.Label lbDescribe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbSeason;
        private System.Windows.Forms.Label lbStudio;
    }
}