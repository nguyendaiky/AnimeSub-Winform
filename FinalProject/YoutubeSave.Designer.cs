
namespace FinalProject
{
    partial class YoutubeSave
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
            this.Author = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Thumbnail = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pctRemove = new System.Windows.Forms.PictureBox();
            this.btnDownload = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // Author
            // 
            this.Author.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.ForeColor = System.Drawing.Color.White;
            this.Author.Location = new System.Drawing.Point(306, 129);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(58, 21);
            this.Author.TabIndex = 4;
            this.Author.Text = "Author";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkOrange;
            this.Title.Location = new System.Drawing.Point(306, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(491, 79);
            this.Title.TabIndex = 6;
            this.Title.Text = "Title";
            // 
            // Thumbnail
            // 
            this.Thumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thumbnail.Dock = System.Windows.Forms.DockStyle.Left;
            this.Thumbnail.ImageRotate = 0F;
            this.Thumbnail.Location = new System.Drawing.Point(0, 0);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.ShadowDecoration.Parent = this.Thumbnail;
            this.Thumbnail.Size = new System.Drawing.Size(300, 200);
            this.Thumbnail.TabIndex = 1;
            this.Thumbnail.TabStop = false;
            this.Thumbnail.Click += new System.EventHandler(this.Mouse_Click);
            // 
            // pctRemove
            // 
            this.pctRemove.BackColor = System.Drawing.Color.DarkOrange;
            this.pctRemove.BackgroundImage = global::FinalProject.Properties.Resources.x;
            this.pctRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctRemove.Location = new System.Drawing.Point(0, 0);
            this.pctRemove.Name = "pctRemove";
            this.pctRemove.Size = new System.Drawing.Size(27, 23);
            this.pctRemove.TabIndex = 36;
            this.pctRemove.TabStop = false;
            this.pctRemove.Click += new System.EventHandler(this.pctRemove_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDownload.BackgroundImage = global::FinalProject.Properties.Resources.download;
            this.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDownload.CheckedState.Parent = this.btnDownload;
            this.btnDownload.CustomImages.Parent = this.btnDownload;
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.DisabledState.Parent = this.btnDownload;
            this.btnDownload.FillColor = System.Drawing.Color.Transparent;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.HoverState.Parent = this.btnDownload;
            this.btnDownload.Location = new System.Drawing.Point(762, 162);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDownload.ShadowDecoration.Parent = this.btnDownload;
            this.btnDownload.Size = new System.Drawing.Size(35, 35);
            this.btnDownload.TabIndex = 37;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // YoutubeSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pctRemove);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Thumbnail);
            this.Name = "YoutubeSave";
            this.Size = new System.Drawing.Size(800, 200);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2PictureBox Thumbnail;
        public System.Windows.Forms.Label Author;
        public System.Windows.Forms.PictureBox pctRemove;
        public System.Windows.Forms.Label Title;
        private Guna.UI2.WinForms.Guna2CircleButton btnDownload;
    }
}
