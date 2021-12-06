
namespace FinalProject
{
    partial class Store
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
            this.tbCtrlStore = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbPageLib = new System.Windows.Forms.TabPage();
            this.tbPageYours = new System.Windows.Forms.TabPage();
            this.tbHistory = new System.Windows.Forms.TabPage();
            this.tbCtrlStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlStore
            // 
            this.tbCtrlStore.Controls.Add(this.tbPageLib);
            this.tbCtrlStore.Controls.Add(this.tbPageYours);
            this.tbCtrlStore.Controls.Add(this.tbHistory);
            this.tbCtrlStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCtrlStore.ItemSize = new System.Drawing.Size(180, 40);
            this.tbCtrlStore.Location = new System.Drawing.Point(0, 0);
            this.tbCtrlStore.Name = "tbCtrlStore";
            this.tbCtrlStore.SelectedIndex = 0;
            this.tbCtrlStore.Size = new System.Drawing.Size(822, 449);
            this.tbCtrlStore.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbCtrlStore.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbCtrlStore.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbCtrlStore.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbCtrlStore.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbCtrlStore.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbCtrlStore.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbCtrlStore.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbCtrlStore.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbCtrlStore.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbCtrlStore.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbCtrlStore.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbCtrlStore.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbCtrlStore.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbCtrlStore.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbCtrlStore.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbCtrlStore.TabIndex = 0;
            this.tbCtrlStore.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbCtrlStore.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbPageLib
            // 
            this.tbPageLib.Location = new System.Drawing.Point(4, 44);
            this.tbPageLib.Name = "tbPageLib";
            this.tbPageLib.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageLib.Size = new System.Drawing.Size(814, 401);
            this.tbPageLib.TabIndex = 0;
            this.tbPageLib.Text = "Thư viện phim";
            this.tbPageLib.UseVisualStyleBackColor = true;
            // 
            // tbPageYours
            // 
            this.tbPageYours.Location = new System.Drawing.Point(4, 44);
            this.tbPageYours.Name = "tbPageYours";
            this.tbPageYours.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageYours.Size = new System.Drawing.Size(814, 401);
            this.tbPageYours.TabIndex = 1;
            this.tbPageYours.Text = "Kho của bạn";
            this.tbPageYours.UseVisualStyleBackColor = true;
            // 
            // tbHistory
            // 
            this.tbHistory.Location = new System.Drawing.Point(4, 44);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(814, 401);
            this.tbHistory.TabIndex = 2;
            this.tbHistory.Text = "Lịch sử xem phim";
            this.tbHistory.UseVisualStyleBackColor = true;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 449);
            this.Controls.Add(this.tbCtrlStore);
            this.Name = "Store";
            this.tbCtrlStore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tbCtrlStore;
        private System.Windows.Forms.TabPage tbPageLib;
        private System.Windows.Forms.TabPage tbPageYours;
        private System.Windows.Forms.TabPage tbHistory;
    }
}