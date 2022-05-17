namespace QLBANXE
{
    partial class HangHoaList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANH = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateButton
            // 
            this.CreateButton.Image = global::QLBANXE.Properties.Resources.icon_plus_70;
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(65, 20);
            this.CreateButton.Text = "Thêm";
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Image = global::QLBANXE.Properties.Resources.icon_edit_soft_fill_70;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(54, 20);
            this.EditButton.Text = "Sửa";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = global::QLBANXE.Properties.Resources.icon_remove_color_70;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(55, 20);
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = global::QLBANXE.Properties.Resources.icon_close_ios_filled_70;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 20);
            this.BackButton.Text = "Đóng";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = global::QLBANXE.Properties.Resources.icon_refresh_soft_fill_70;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(65, 20);
            this.RefreshButton.Text = "Tải lại";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearch.Location = new System.Drawing.Point(543, 83);
            this.inputSearch.Multiline = true;
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(245, 21);
            this.inputSearch.TabIndex = 2;
            // 
            // gridView
            // 
            this.gridView.AllowUserToOrderColumns = true;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHH,
            this.TENHH,
            this.DVT,
            this.MANCC,
            this.SOLUONG,
            this.GIAXUAT,
            this.GIANHAP,
            this.HINHANH,
            this.ID,
            this.NhaCungCapID});
            this.gridView.Location = new System.Drawing.Point(0, 117);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(800, 333);
            this.gridView.TabIndex = 4;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã hàng hóa";
            this.MAHH.Name = "MAHH";
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "Tên hàng hóa";
            this.TENHH.Name = "TENHH";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.Name = "MANCC";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // GIAXUAT
            // 
            this.GIAXUAT.DataPropertyName = "GIAXUAT";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.GIAXUAT.DefaultCellStyle = dataGridViewCellStyle1;
            this.GIAXUAT.HeaderText = "Giá xuất";
            this.GIAXUAT.Name = "GIAXUAT";
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.GIANHAP.DefaultCellStyle = dataGridViewCellStyle2;
            this.GIANHAP.HeaderText = "Giá nhập";
            this.GIANHAP.Name = "GIANHAP";
            // 
            // HINHANH
            // 
            this.HINHANH.DataPropertyName = "HINHANH";
            this.HINHANH.HeaderText = "Hình ảnh";
            this.HINHANH.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.HINHANH.MinimumWidth = 100;
            this.HINHANH.Name = "HINHANH";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // NhaCungCapID
            // 
            this.NhaCungCapID.DataPropertyName = "NhaCungCapID";
            this.NhaCungCapID.HeaderText = "NhaCungCapID";
            this.NhaCungCapID.Name = "NhaCungCapID";
            this.NhaCungCapID.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "HINHANH";
            this.dataGridViewImageColumn1.HeaderText = "Hình ảnh";
            this.dataGridViewImageColumn1.Image = global::QLBANXE.Properties.Resources.icon_no_image_color_70;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 100;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.BackgroundImage = global::QLBANXE.Properties.Resources.icon_search_ios_filled_70;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.Location = new System.Drawing.Point(516, 81);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 24);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HangHoaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HangHoaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.Frame_Load);
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewImageColumn HINHANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCapID;
    }
}