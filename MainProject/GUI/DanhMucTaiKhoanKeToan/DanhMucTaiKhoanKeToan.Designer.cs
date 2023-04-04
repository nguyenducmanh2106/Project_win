namespace KETOANDOANHTHU
{
    partial class DanhMucTaiKhoanKeToan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.MATK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAPTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateButton,
            this.EditButton,
            this.DeleteButton,
            this.BackButton,
            this.RefreshButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateButton
            // 
            this.CreateButton.Image = global::KETOANDOANHTHU.Properties.Resources.icon_plus_70;
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(65, 20);
            this.CreateButton.Text = "Thêm";
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Image = global::KETOANDOANHTHU.Properties.Resources.icon_edit_soft_fill_70;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(54, 20);
            this.EditButton.Text = "Sửa";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = global::KETOANDOANHTHU.Properties.Resources.icon_remove_color_70;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(55, 20);
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = global::KETOANDOANHTHU.Properties.Resources.icon_close_ios_filled_70;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 20);
            this.BackButton.Text = "Đóng";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = global::KETOANDOANHTHU.Properties.Resources.icon_refresh_soft_fill_70;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(65, 20);
            this.RefreshButton.Text = "Tải lại";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearch.Location = new System.Drawing.Point(814, 114);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputSearch.Multiline = true;
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(355, 30);
            this.inputSearch.TabIndex = 2;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATK,
            this.TENTK,
            this.CAPTK,
            this.TKCT,
            this.ID});
            this.gridView.Location = new System.Drawing.Point(0, 168);
            this.gridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(1200, 525);
            this.gridView.TabIndex = 4;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // MATK
            // 
            this.MATK.DataPropertyName = "MATK";
            this.MATK.HeaderText = "Mã tài khoản";
            this.MATK.Name = "MATK";
            // 
            // TENTK
            // 
            this.TENTK.DataPropertyName = "TENTK";
            this.TENTK.HeaderText = "Tên tài khoản";
            this.TENTK.Name = "TENTK";
            // 
            // CAPTK
            // 
            this.CAPTK.DataPropertyName = "CAPTK";
            this.CAPTK.HeaderText = "Cấp TK";
            this.CAPTK.Name = "CAPTK";
            // 
            // TKCT
            // 
            this.TKCT.DataPropertyName = "TKCT_TEXT";
            this.TKCT.HeaderText = "Tài khoản cấp trên";
            this.TKCT.Name = "TKCT";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.BackgroundImage = global::KETOANDOANHTHU.Properties.Resources.icon_search_ios_filled_70;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.Location = new System.Drawing.Point(774, 113);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(42, 32);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DanhMucTaiKhoanKeToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KETOANDOANHTHU.Properties.Resources.businesspeople_working_finance_accounting_analyze_financi;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DanhMucTaiKhoanKeToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.DanhMucTaiKhoan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateButton;
        private System.Windows.Forms.ToolStripMenuItem EditButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteButton;
        private System.Windows.Forms.ToolStripMenuItem BackButton;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolStripMenuItem RefreshButton;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAPTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}