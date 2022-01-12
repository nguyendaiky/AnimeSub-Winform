
namespace FinalProject
{
    partial class FrmFilter
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
            this.flowPnlType = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.grpBoxType = new System.Windows.Forms.GroupBox();
            this.grpBoxSeason = new System.Windows.Forms.GroupBox();
            this.flowPnlSeason = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoxYear = new System.Windows.Forms.GroupBox();
            this.flowPnlYear = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoxStudio = new System.Windows.Forms.GroupBox();
            this.flowPnlStudio = new System.Windows.Forms.FlowLayoutPanel();
            this.grpBoxType.SuspendLayout();
            this.grpBoxSeason.SuspendLayout();
            this.grpBoxYear.SuspendLayout();
            this.grpBoxStudio.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPnlType
            // 
            this.flowPnlType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPnlType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPnlType.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.flowPnlType.ForeColor = System.Drawing.Color.Black;
            this.flowPnlType.Location = new System.Drawing.Point(3, 28);
            this.flowPnlType.Name = "flowPnlType";
            this.flowPnlType.Size = new System.Drawing.Size(898, 127);
            this.flowPnlType.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFilter.BorderRadius = 10;
            this.btnFilter.CheckedState.Parent = this.btnFilter;
            this.btnFilter.CustomImages.Parent = this.btnFilter;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.DisabledState.Parent = this.btnFilter;
            this.btnFilter.FillColor = System.Drawing.Color.Black;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnFilter.HoverState.Parent = this.btnFilter;
            this.btnFilter.Location = new System.Drawing.Point(362, 466);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(177, 45);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Lọc Anime";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // grpBoxType
            // 
            this.grpBoxType.BackColor = System.Drawing.Color.LightGray;
            this.grpBoxType.Controls.Add(this.flowPnlType);
            this.grpBoxType.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxType.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.grpBoxType.ForeColor = System.Drawing.Color.Black;
            this.grpBoxType.Location = new System.Drawing.Point(0, 0);
            this.grpBoxType.Name = "grpBoxType";
            this.grpBoxType.Size = new System.Drawing.Size(904, 158);
            this.grpBoxType.TabIndex = 3;
            this.grpBoxType.TabStop = false;
            this.grpBoxType.Text = "Thể loại";
            // 
            // grpBoxSeason
            // 
            this.grpBoxSeason.Controls.Add(this.flowPnlSeason);
            this.grpBoxSeason.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.grpBoxSeason.ForeColor = System.Drawing.Color.Black;
            this.grpBoxSeason.Location = new System.Drawing.Point(3, 164);
            this.grpBoxSeason.Name = "grpBoxSeason";
            this.grpBoxSeason.Size = new System.Drawing.Size(362, 141);
            this.grpBoxSeason.TabIndex = 4;
            this.grpBoxSeason.TabStop = false;
            this.grpBoxSeason.Text = "Mùa";
            // 
            // flowPnlSeason
            // 
            this.flowPnlSeason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPnlSeason.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPnlSeason.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.flowPnlSeason.Location = new System.Drawing.Point(3, 41);
            this.flowPnlSeason.Name = "flowPnlSeason";
            this.flowPnlSeason.Size = new System.Drawing.Size(356, 97);
            this.flowPnlSeason.TabIndex = 0;
            // 
            // grpBoxYear
            // 
            this.grpBoxYear.Controls.Add(this.flowPnlYear);
            this.grpBoxYear.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.grpBoxYear.ForeColor = System.Drawing.Color.Black;
            this.grpBoxYear.Location = new System.Drawing.Point(371, 164);
            this.grpBoxYear.Name = "grpBoxYear";
            this.grpBoxYear.Size = new System.Drawing.Size(521, 141);
            this.grpBoxYear.TabIndex = 4;
            this.grpBoxYear.TabStop = false;
            this.grpBoxYear.Text = "Năm";
            // 
            // flowPnlYear
            // 
            this.flowPnlYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPnlYear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPnlYear.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.flowPnlYear.Location = new System.Drawing.Point(3, 41);
            this.flowPnlYear.Name = "flowPnlYear";
            this.flowPnlYear.Size = new System.Drawing.Size(515, 97);
            this.flowPnlYear.TabIndex = 0;
            // 
            // grpBoxStudio
            // 
            this.grpBoxStudio.Controls.Add(this.flowPnlStudio);
            this.grpBoxStudio.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.grpBoxStudio.ForeColor = System.Drawing.Color.Black;
            this.grpBoxStudio.Location = new System.Drawing.Point(6, 311);
            this.grpBoxStudio.Name = "grpBoxStudio";
            this.grpBoxStudio.Size = new System.Drawing.Size(886, 141);
            this.grpBoxStudio.TabIndex = 5;
            this.grpBoxStudio.TabStop = false;
            this.grpBoxStudio.Text = "Studio";
            // 
            // flowPnlStudio
            // 
            this.flowPnlStudio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowPnlStudio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowPnlStudio.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.flowPnlStudio.Location = new System.Drawing.Point(3, 41);
            this.flowPnlStudio.Name = "flowPnlStudio";
            this.flowPnlStudio.Size = new System.Drawing.Size(880, 97);
            this.flowPnlStudio.TabIndex = 0;
            // 
            // FrmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(904, 524);
            this.Controls.Add(this.grpBoxStudio);
            this.Controls.Add(this.grpBoxYear);
            this.Controls.Add(this.grpBoxSeason);
            this.Controls.Add(this.grpBoxType);
            this.Controls.Add(this.btnFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpBoxType.ResumeLayout(false);
            this.grpBoxSeason.ResumeLayout(false);
            this.grpBoxYear.ResumeLayout(false);
            this.grpBoxStudio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPnlType;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private System.Windows.Forms.GroupBox grpBoxType;
        private System.Windows.Forms.GroupBox grpBoxSeason;
        private System.Windows.Forms.FlowLayoutPanel flowPnlSeason;
        private System.Windows.Forms.GroupBox grpBoxYear;
        private System.Windows.Forms.FlowLayoutPanel flowPnlYear;
        private System.Windows.Forms.GroupBox grpBoxStudio;
        private System.Windows.Forms.FlowLayoutPanel flowPnlStudio;
    }
}