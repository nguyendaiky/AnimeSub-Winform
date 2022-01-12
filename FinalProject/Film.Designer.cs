
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
            this.lbName = new System.Windows.Forms.Label();
            this.pctImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pctRemove = new System.Windows.Forms.PictureBox();
            this.btnRate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 199);
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
            this.lbView.Location = new System.Drawing.Point(58, 200);
            this.lbView.Name = "lbView";
            this.lbView.Size = new System.Drawing.Size(10, 15);
            this.lbView.TabIndex = 3;
            this.lbView.Text = "0";
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbName.Location = new System.Drawing.Point(0, 178);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            this.lbName.MouseHover += new System.EventHandler(this.lbName_MouseHover);
            // 
            // pctImage
            // 
            this.pctImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctImage.BackgroundImage")));
            this.pctImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctImage.BorderRadius = 15;
            this.pctImage.FillColor = System.Drawing.Color.Transparent;
            this.pctImage.ImageRotate = 0F;
            this.pctImage.Location = new System.Drawing.Point(0, 0);
            this.pctImage.Name = "pctImage";
            this.pctImage.ShadowDecoration.Parent = this.pctImage;
            this.pctImage.Size = new System.Drawing.Size(144, 176);
            this.pctImage.TabIndex = 0;
            this.pctImage.TabStop = false;
            this.pctImage.Click += new System.EventHandler(this.pctImage_Click);
            this.pctImage.MouseHover += new System.EventHandler(this.pctImage_MouseHover);
            // 
            // pctRemove
            // 
            this.pctRemove.BackColor = System.Drawing.Color.DarkOrange;
            this.pctRemove.BackgroundImage = global::FinalProject.Properties.Resources.x;
            this.pctRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctRemove.Location = new System.Drawing.Point(117, 0);
            this.pctRemove.Name = "pctRemove";
            this.pctRemove.Size = new System.Drawing.Size(27, 23);
            this.pctRemove.TabIndex = 35;
            this.pctRemove.TabStop = false;
            this.pctRemove.Visible = false;
            this.pctRemove.Click += new System.EventHandler(this.pctRemove_Click);
            // 
            // btnRate
            // 
            this.btnRate.BackColor = System.Drawing.Color.Transparent;
            this.btnRate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRate.BorderRadius = 15;
            this.btnRate.BorderThickness = 1;
            this.btnRate.CheckedState.Parent = this.btnRate;
            this.btnRate.CustomBorderColor = System.Drawing.Color.White;
            this.btnRate.CustomImages.Parent = this.btnRate;
            this.btnRate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRate.DisabledState.Parent = this.btnRate;
            this.btnRate.FillColor = System.Drawing.Color.Black;
            this.btnRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRate.HoverState.Parent = this.btnRate;
            this.btnRate.Image = global::FinalProject.Properties.Resources.star;
            this.btnRate.Location = new System.Drawing.Point(0, 0);
            this.btnRate.Name = "btnRate";
            this.btnRate.ShadowDecoration.Parent = this.btnRate;
            this.btnRate.Size = new System.Drawing.Size(52, 33);
            this.btnRate.TabIndex = 36;
            this.btnRate.Text = "0.0";
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.pctRemove);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbView);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pctImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Film";
            this.Size = new System.Drawing.Size(144, 218);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbView;
        public Guna.UI2.WinForms.Guna2PictureBox pctImage;
        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.PictureBox pctRemove;
        public Guna.UI2.WinForms.Guna2Button btnRate;
    }
}
