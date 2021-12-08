
namespace FinalProject
{
    partial class Film
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbView = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnRate = new Guna.UI2.WinForms.Guna2Button();
            this.pctImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 241);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(49, 15);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Lượt xem:";
            // 
            // lbView
            // 
            this.lbView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbView.BackColor = System.Drawing.Color.Transparent;
            this.lbView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbView.ForeColor = System.Drawing.Color.White;
            this.lbView.Location = new System.Drawing.Point(58, 241);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(10, 15);
            this.lbView.TabIndex = 3;
            this.lbView.Text = "0";
            // 
            // btnRate
            // 
            this.btnRate.BackColor = System.Drawing.Color.Transparent;
            this.btnRate.BorderColor = System.Drawing.Color.Transparent;
            this.btnRate.BorderRadius = 10;
            this.btnRate.CheckedState.Parent = this.btnRate;
            this.btnRate.CustomImages.Parent = this.btnRate;
            this.btnRate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRate.DisabledState.Parent = this.btnRate;
            this.btnRate.Enabled = false;
            this.btnRate.FillColor = System.Drawing.Color.DimGray;
            this.btnRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(236)))), ((int)(((byte)(66)))));
            this.btnRate.HoverState.Parent = this.btnRate;
            this.btnRate.Image = global::FinalProject.Properties.Resources.star;
            this.btnRate.Location = new System.Drawing.Point(0, 0);
            this.btnRate.Name = "btnRate";
            this.btnRate.PressedColor = System.Drawing.Color.Transparent;
            this.btnRate.ShadowDecoration.Parent = this.btnRate;
            this.btnRate.Size = new System.Drawing.Size(71, 25);
            this.btnRate.TabIndex = 4;
            this.btnRate.Text = "0.0";
            // 
            // pctImage
            // 
            this.pctImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctImage.BackgroundImage")));
            this.pctImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctImage.BorderRadius = 15;
            this.pctImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctImage.FillColor = System.Drawing.Color.Transparent;
            this.pctImage.ImageRotate = 0F;
            this.pctImage.Location = new System.Drawing.Point(0, 0);
            this.pctImage.Name = "pctImage";
            this.pctImage.ShadowDecoration.Parent = this.pctImage;
            this.pctImage.Size = new System.Drawing.Size(163, 208);
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            this.pctImage.Click += new System.EventHandler(this.pctImage_Click);
            this.pctImage.MouseHover += new System.EventHandler(this.pctImage_MouseHover);
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbName.Location = new System.Drawing.Point(0, 224);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 15);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            this.lbName.MouseHover += new System.EventHandler(this.lbName_MouseHover);
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pctImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Film";
            this.Size = new System.Drawing.Size(163, 259);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnRate;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbView;
        public Guna.UI2.WinForms.Guna2PictureBox pctImage;
        public System.Windows.Forms.Label lbName;
    }
}
