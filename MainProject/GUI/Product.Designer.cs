namespace QLBANXE
{
    partial class Product
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
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahangxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbMauSac = new System.Windows.Forms.TextBox();
            this.tbLoaiXe = new System.Windows.Forms.TextBox();
            this.cbbMaHangXe = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cbbTypeSearch = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MauSac,
            this.Loaixe,
            this.Mahangxe});
            this.dgvSanPham.Location = new System.Drawing.Point(57, 366);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(843, 190);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // MauSac
            // 
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.HeaderText = "Màu sắc";
            this.MauSac.MinimumWidth = 6;
            this.MauSac.Name = "MauSac";
            this.MauSac.Width = 125;
            // 
            // Loaixe
            // 
            this.Loaixe.DataPropertyName = "Loaixe";
            this.Loaixe.HeaderText = "Loại xe";
            this.Loaixe.MinimumWidth = 6;
            this.Loaixe.Name = "Loaixe";
            this.Loaixe.Width = 125;
            // 
            // Mahangxe
            // 
            this.Mahangxe.DataPropertyName = "Mahangxe";
            this.Mahangxe.HeaderText = "Mã hãng xe";
            this.Mahangxe.MinimumWidth = 6;
            this.Mahangxe.Name = "Mahangxe";
            this.Mahangxe.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Màu sắc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã hãng xe";
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(275, 69);
            this.tbMaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(235, 22);
            this.tbMaSP.TabIndex = 6;
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(275, 112);
            this.tbTenSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(235, 22);
            this.tbTenSP.TabIndex = 7;
            // 
            // tbMauSac
            // 
            this.tbMauSac.Location = new System.Drawing.Point(275, 156);
            this.tbMauSac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMauSac.Name = "tbMauSac";
            this.tbMauSac.Size = new System.Drawing.Size(235, 22);
            this.tbMauSac.TabIndex = 8;
            // 
            // tbLoaiXe
            // 
            this.tbLoaiXe.Location = new System.Drawing.Point(275, 201);
            this.tbLoaiXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLoaiXe.Name = "tbLoaiXe";
            this.tbLoaiXe.Size = new System.Drawing.Size(235, 22);
            this.tbLoaiXe.TabIndex = 9;
            // 
            // cbbMaHangXe
            // 
            this.cbbMaHangXe.FormattingEnabled = true;
            this.cbbMaHangXe.Location = new System.Drawing.Point(275, 250);
            this.cbbMaHangXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMaHangXe.Name = "cbbMaHangXe";
            this.cbbMaHangXe.Size = new System.Drawing.Size(235, 24);
            this.cbbMaHangXe.TabIndex = 10;
            // 
            // btn_Add
            // 
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Add.Location = new System.Drawing.Point(627, 69);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(117, 28);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Update.Location = new System.Drawing.Point(627, 132);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(117, 28);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Delete.Location = new System.Drawing.Point(627, 198);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(117, 28);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Search.Location = new System.Drawing.Point(627, 319);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(117, 28);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Thoat.Location = new System.Drawing.Point(471, 562);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cbbTypeSearch
            // 
            this.cbbTypeSearch.FormattingEnabled = true;
            this.cbbTypeSearch.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Màu sắc"});
            this.cbbTypeSearch.Location = new System.Drawing.Point(275, 318);
            this.cbbTypeSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbTypeSearch.Name = "cbbTypeSearch";
            this.cbbTypeSearch.Size = new System.Drawing.Size(129, 24);
            this.cbbTypeSearch.TabIndex = 16;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(413, 319);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(177, 22);
            this.tbSearch.TabIndex = 17;
            // 
            // btn_Reload
            // 
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Reload.Location = new System.Drawing.Point(627, 250);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(117, 28);
            this.btn_Reload.TabIndex = 18;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(339, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 625);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbbTypeSearch);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cbbMaHangXe);
            this.Controls.Add(this.tbLoaiXe);
            this.Controls.Add(this.tbMauSac);
            this.Controls.Add(this.tbTenSP);
            this.Controls.Add(this.tbMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbMauSac;
        private System.Windows.Forms.TextBox tbLoaiXe;
        private System.Windows.Forms.ComboBox cbbMaHangXe;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cbbTypeSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahangxe;
    }
}