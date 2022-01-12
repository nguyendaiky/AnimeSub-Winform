
namespace FinalProject
{
    partial class Comment
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
            this.pctAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbComment = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAvatar
            // 
            this.pctAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctAvatar.ImageRotate = 0F;
            this.pctAvatar.Location = new System.Drawing.Point(0, 0);
            this.pctAvatar.Name = "pctAvatar";
            this.pctAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctAvatar.ShadowDecoration.Parent = this.pctAvatar;
            this.pctAvatar.Size = new System.Drawing.Size(80, 80);
            this.pctAvatar.TabIndex = 0;
            this.pctAvatar.TabStop = false;
            // 
            // lbComment
            // 
            this.lbComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbComment.Location = new System.Drawing.Point(87, 29);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(710, 51);
            this.lbComment.TabIndex = 1;
            this.lbComment.Text = "Comment";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbName.Location = new System.Drawing.Point(86, 5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 20);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name";
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this.pctAvatar);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(800, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pctAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pctAvatar;
        private System.Windows.Forms.Label lbComment;
        private System.Windows.Forms.Label lbName;
    }
}
