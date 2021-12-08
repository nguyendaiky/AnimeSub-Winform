
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCtrlStore = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbPageLib = new System.Windows.Forms.TabPage();
            this.flowPnlButton = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPageYours = new System.Windows.Forms.TabPage();
            this.tbHistory = new System.Windows.Forms.TabPage();
            this.gridViewLib = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tbCtrlStore.SuspendLayout();
            this.tbPageLib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLib)).BeginInit();
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
            this.tbPageLib.Controls.Add(this.gridViewLib);
            this.tbPageLib.Controls.Add(this.flowPnlButton);
            this.tbPageLib.Location = new System.Drawing.Point(4, 44);
            this.tbPageLib.Name = "tbPageLib";
            this.tbPageLib.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageLib.Size = new System.Drawing.Size(814, 401);
            this.tbPageLib.TabIndex = 0;
            this.tbPageLib.Text = "Thư viện phim";
            this.tbPageLib.UseVisualStyleBackColor = true;
            // 
            // flowPnlButton
            // 
            this.flowPnlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPnlButton.Location = new System.Drawing.Point(3, 3);
            this.flowPnlButton.Name = "flowPnlButton";
            this.flowPnlButton.Size = new System.Drawing.Size(808, 34);
            this.flowPnlButton.TabIndex = 0;
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
            // gridViewLib
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViewLib.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewLib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewLib.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewLib.BackgroundColor = System.Drawing.Color.White;
            this.gridViewLib.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewLib.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewLib.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewLib.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewLib.ColumnHeadersHeight = 41;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewLib.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewLib.EnableHeadersVisualStyles = false;
            this.gridViewLib.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewLib.Location = new System.Drawing.Point(3, 43);
            this.gridViewLib.Name = "gridViewLib";
            this.gridViewLib.RowHeadersVisible = false;
            this.gridViewLib.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewLib.Size = new System.Drawing.Size(808, 358);
            this.gridViewLib.TabIndex = 1;
            this.gridViewLib.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewLib.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewLib.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewLib.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewLib.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewLib.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewLib.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewLib.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridViewLib.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewLib.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridViewLib.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridViewLib.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridViewLib.ThemeStyle.HeaderStyle.Height = 41;
            this.gridViewLib.ThemeStyle.ReadOnly = false;
            this.gridViewLib.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewLib.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewLib.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridViewLib.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewLib.ThemeStyle.RowsStyle.Height = 22;
            this.gridViewLib.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewLib.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 449);
            this.Controls.Add(this.tbCtrlStore);
            this.Name = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            this.tbCtrlStore.ResumeLayout(false);
            this.tbPageLib.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLib)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tbCtrlStore;
        private System.Windows.Forms.TabPage tbPageLib;
        private System.Windows.Forms.TabPage tbPageYours;
        private System.Windows.Forms.TabPage tbHistory;
        private System.Windows.Forms.FlowLayoutPanel flowPnlButton;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewLib;
    }
}