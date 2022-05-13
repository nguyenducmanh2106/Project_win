namespace QLBANXE
{
    partial class BangGia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonGiaMua = new System.Windows.Forms.TextBox();
            this.dgvBangGia = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaylamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.dtpNgaylamgia = new System.Windows.Forms.DateTimePicker();
            this.btn_THEM = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_DELETE = new System.Windows.Forms.Button();
            this.btn_RELOAD = new System.Windows.Forms.Button();
            this.btn_SEARCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(448, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG GIÁ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày cập nhật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá mua";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(348, 212);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(252, 22);
            this.txtDonGiaBan.TabIndex = 7;
            // 
            // txtDonGiaMua
            // 
            this.txtDonGiaMua.Location = new System.Drawing.Point(351, 267);
            this.txtDonGiaMua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGiaMua.Name = "txtDonGiaMua";
            this.txtDonGiaMua.Size = new System.Drawing.Size(249, 22);
            this.txtDonGiaMua.TabIndex = 8;
            // 
            // dgvBangGia
            // 
            this.dgvBangGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.Ngaylamgia,
            this.giaban,
            this.giamua});
            this.dgvBangGia.Location = new System.Drawing.Point(89, 350);
            this.dgvBangGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBangGia.Name = "dgvBangGia";
            this.dgvBangGia.RowHeadersWidth = 51;
            this.dgvBangGia.Size = new System.Drawing.Size(863, 155);
            this.dgvBangGia.TabIndex = 9;
            this.dgvBangGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // Ngaylamgia
            // 
            this.Ngaylamgia.DataPropertyName = "Ngaylamgia";
            this.Ngaylamgia.HeaderText = "Ngày cập nhật";
            this.Ngaylamgia.MinimumWidth = 6;
            this.Ngaylamgia.Name = "Ngaylamgia";
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "giaban";
            this.giaban.HeaderText = "Đơn giá bán";
            this.giaban.MinimumWidth = 6;
            this.giaban.Name = "giaban";
            // 
            // giamua
            // 
            this.giamua.DataPropertyName = "giamua";
            this.giamua.HeaderText = "Đơn giá mua";
            this.giamua.MinimumWidth = 6;
            this.giamua.Name = "giamua";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(476, 535);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(343, 90);
            this.cbbMaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(257, 24);
            this.cbbMaSP.TabIndex = 11;
            // 
            // dtpNgaylamgia
            // 
            this.dtpNgaylamgia.Enabled = false;
            this.dtpNgaylamgia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylamgia.Location = new System.Drawing.Point(348, 153);
            this.dtpNgaylamgia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaylamgia.Name = "dtpNgaylamgia";
            this.dtpNgaylamgia.Size = new System.Drawing.Size(252, 22);
            this.dtpNgaylamgia.TabIndex = 12;
            // 
            // btn_THEM
            // 
            this.btn_THEM.BackColor = System.Drawing.SystemColors.Control;
            this.btn_THEM.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_THEM.Location = new System.Drawing.Point(689, 87);
            this.btn_THEM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_THEM.Name = "btn_THEM";
            this.btn_THEM.Size = new System.Drawing.Size(100, 28);
            this.btn_THEM.TabIndex = 13;
            this.btn_THEM.Text = "Thêm";
            this.btn_THEM.UseVisualStyleBackColor = false;
            this.btn_THEM.Click += new System.EventHandler(this.btn_THEM_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Update.Location = new System.Drawing.Point(689, 153);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 28);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_DELETE.Location = new System.Drawing.Point(836, 90);
            this.btn_DELETE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(100, 28);
            this.btn_DELETE.TabIndex = 15;
            this.btn_DELETE.Text = "Xóa";
            this.btn_DELETE.UseVisualStyleBackColor = true;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // btn_RELOAD
            // 
            this.btn_RELOAD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RELOAD.Location = new System.Drawing.Point(836, 153);
            this.btn_RELOAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RELOAD.Name = "btn_RELOAD";
            this.btn_RELOAD.Size = new System.Drawing.Size(100, 28);
            this.btn_RELOAD.TabIndex = 16;
            this.btn_RELOAD.Text = "Reload";
            this.btn_RELOAD.UseVisualStyleBackColor = true;
            this.btn_RELOAD.Click += new System.EventHandler(this.btn_RELOAD_Click);
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SEARCH.Location = new System.Drawing.Point(689, 213);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(100, 28);
            this.btn_SEARCH.TabIndex = 17;
            this.btn_SEARCH.Text = "Tìm theo mã sp";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // BangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 596);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.btn_RELOAD);
            this.Controls.Add(this.btn_DELETE);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_THEM);
            this.Controls.Add(this.dtpNgaylamgia);
            this.Controls.Add(this.cbbMaSP);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dgvBangGia);
            this.Controls.Add(this.txtDonGiaMua);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "BangGia";
            this.Text = "BangGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.BangGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaMua;
        private System.Windows.Forms.DataGridView dgvBangGia;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.DateTimePicker dtpNgaylamgia;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_DELETE;
        private System.Windows.Forms.Button btn_RELOAD;
        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaylamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.Button btn_THEM;
    }
}