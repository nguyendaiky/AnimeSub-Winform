
namespace FinalProject
{
    partial class WatchFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchFilm));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.LayoutPnlEp = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(0, 0);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(807, 409);
            this.WMP.TabIndex = 0;
            // 
            // LayoutPnlEp
            // 
            this.LayoutPnlEp.AllowDrop = true;
            this.LayoutPnlEp.AutoScroll = true;
            this.LayoutPnlEp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.LayoutPnlEp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LayoutPnlEp.Location = new System.Drawing.Point(0, 406);
            this.LayoutPnlEp.Name = "LayoutPnlEp";
            this.LayoutPnlEp.Size = new System.Drawing.Size(807, 63);
            this.LayoutPnlEp.TabIndex = 1;
            // 
            // WatchFilm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 469);
            this.Controls.Add(this.LayoutPnlEp);
            this.Controls.Add(this.WMP);
            this.Name = "WatchFilm";
            this.Text = "WatchFilm";
            this.Load += new System.EventHandler(this.WatchFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.FlowLayoutPanel LayoutPnlEp;
    }
}