namespace QLBANXE
{
    partial class ThongKe
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
            this.dgvSPBAN = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSPNHAP = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongSLNhap = new System.Windows.Forms.TextBox();
            this.txtTongSPnhap = new System.Windows.Forms.TextBox();
            this.txtTongSLBan = new System.Windows.Forms.TextBox();
            this.txtTongSPban = new System.Windows.Forms.TextBox();
            this.txtTongTienNhap = new System.Windows.Forms.TextBox();
            this.txtTongTienBan = new System.Windows.Forms.TextBox();
            this.txtTienLai = new System.Windows.Forms.TextBox();
            this.btn_RELOAD = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPBAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPNHAP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(387, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // dgvSPBAN
            // 
            this.dgvSPBAN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSPBAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPBAN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SlXuat,
            this.giaban});
            this.dgvSPBAN.Enabled = false;
            this.dgvSPBAN.Location = new System.Drawing.Point(427, 124);
            this.dgvSPBAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSPBAN.Name = "dgvSPBAN";
            this.dgvSPBAN.RowHeadersWidth = 51;
            this.dgvSPBAN.Size = new System.Drawing.Size(569, 192);
            this.dgvSPBAN.TabIndex = 1;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // SlXuat
            // 
            this.SlXuat.DataPropertyName = "SlXuat";
            this.SlXuat.HeaderText = "Số lượng bán";
            this.SlXuat.MinimumWidth = 6;
            this.SlXuat.Name = "SlXuat";
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "DgXuat";
            this.giaban.HeaderText = "Đơn giá bán";
            this.giaban.MinimumWidth = 6;
            this.giaban.Name = "giaban";
            // 
            // dgvSPNHAP
            // 
            this.dgvSPNHAP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSPNHAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPNHAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ten,
            this.SlNhap,
            this.giamua});
            this.dgvSPNHAP.Location = new System.Drawing.Point(427, 394);
            this.dgvSPNHAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSPNHAP.Name = "dgvSPNHAP";
            this.dgvSPNHAP.RowHeadersWidth = 51;
            this.dgvSPNHAP.Size = new System.Drawing.Size(568, 199);
            this.dgvSPNHAP.TabIndex = 2;
            // 
            // ma
            // 
            this.ma.DataPropertyName = "MaSP";
            this.ma.HeaderText = "Mã SP";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "TenSP";
            this.ten.HeaderText = "Tên SP";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            // 
            // SlNhap
            // 
            this.SlNhap.DataPropertyName = "SlNhap";
            this.SlNhap.HeaderText = "Số lượng nhập";
            this.SlNhap.MinimumWidth = 6;
            this.SlNhap.Name = "SlNhap";
            // 
            // giamua
            // 
            this.giamua.DataPropertyName = "DgNhap";
            this.giamua.HeaderText = "Đơn giá nhập";
            this.giamua.MinimumWidth = 6;
            this.giamua.Name = "giamua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(423, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "BẢNG SP BÁN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(423, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "BẢNG SP NHẬP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Năm";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(171, 166);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(97, 22);
            this.txtYear.TabIndex = 8;
            // 
            // btn_Filter
            // 
            this.btn_Filter.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Filter.Location = new System.Drawing.Point(293, 164);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(100, 28);
            this.btn_Filter.TabIndex = 9;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 239);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng SL nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tổng SP nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tổng SL bán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 394);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tổng SP bán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 433);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tổng tiền nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 480);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tổng tiền bán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 522);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Lãi";
            // 
            // txtTongSLNhap
            // 
            this.txtTongSLNhap.Enabled = false;
            this.txtTongSLNhap.Location = new System.Drawing.Point(203, 242);
            this.txtTongSLNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongSLNhap.Name = "txtTongSLNhap";
            this.txtTongSLNhap.Size = new System.Drawing.Size(132, 22);
            this.txtTongSLNhap.TabIndex = 17;
            // 
            // txtTongSPnhap
            // 
            this.txtTongSPnhap.Enabled = false;
            this.txtTongSPnhap.Location = new System.Drawing.Point(203, 292);
            this.txtTongSPnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongSPnhap.Name = "txtTongSPnhap";
            this.txtTongSPnhap.Size = new System.Drawing.Size(132, 22);
            this.txtTongSPnhap.TabIndex = 18;
            // 
            // txtTongSLBan
            // 
            this.txtTongSLBan.Enabled = false;
            this.txtTongSLBan.Location = new System.Drawing.Point(201, 334);
            this.txtTongSLBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongSLBan.Name = "txtTongSLBan";
            this.txtTongSLBan.Size = new System.Drawing.Size(132, 22);
            this.txtTongSLBan.TabIndex = 19;
            // 
            // txtTongSPban
            // 
            this.txtTongSPban.Enabled = false;
            this.txtTongSPban.Location = new System.Drawing.Point(201, 385);
            this.txtTongSPban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongSPban.Name = "txtTongSPban";
            this.txtTongSPban.Size = new System.Drawing.Size(132, 22);
            this.txtTongSPban.TabIndex = 20;
            // 
            // txtTongTienNhap
            // 
            this.txtTongTienNhap.Enabled = false;
            this.txtTongTienNhap.Location = new System.Drawing.Point(201, 425);
            this.txtTongTienNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTienNhap.Name = "txtTongTienNhap";
            this.txtTongTienNhap.Size = new System.Drawing.Size(132, 22);
            this.txtTongTienNhap.TabIndex = 21;
            // 
            // txtTongTienBan
            // 
            this.txtTongTienBan.Enabled = false;
            this.txtTongTienBan.Location = new System.Drawing.Point(201, 471);
            this.txtTongTienBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTienBan.Name = "txtTongTienBan";
            this.txtTongTienBan.Size = new System.Drawing.Size(132, 22);
            this.txtTongTienBan.TabIndex = 22;
            // 
            // txtTienLai
            // 
            this.txtTienLai.Enabled = false;
            this.txtTienLai.Location = new System.Drawing.Point(201, 522);
            this.txtTienLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienLai.Name = "txtTienLai";
            this.txtTienLai.Size = new System.Drawing.Size(132, 22);
            this.txtTienLai.TabIndex = 23;
            // 
            // btn_RELOAD
            // 
            this.btn_RELOAD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_RELOAD.Location = new System.Drawing.Point(68, 576);
            this.btn_RELOAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RELOAD.Name = "btn_RELOAD";
            this.btn_RELOAD.Size = new System.Drawing.Size(100, 28);
            this.btn_RELOAD.TabIndex = 24;
            this.btn_RELOAD.Text = "Reload";
            this.btn_RELOAD.UseVisualStyleBackColor = true;
            this.btn_RELOAD.Click += new System.EventHandler(this.btn_RELOAD_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.Location = new System.Drawing.Point(251, 576);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 25;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // cbbMonth
            // 
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "-Chọn tháng-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbMonth.Location = new System.Drawing.Point(40, 166);
            this.cbbMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(103, 24);
            this.cbbMonth.TabIndex = 26;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 639);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_RELOAD);
            this.Controls.Add(this.txtTienLai);
            this.Controls.Add(this.txtTongTienBan);
            this.Controls.Add(this.txtTongTienNhap);
            this.Controls.Add(this.txtTongSPban);
            this.Controls.Add(this.txtTongSLBan);
            this.Controls.Add(this.txtTongSPnhap);
            this.Controls.Add(this.txtTongSLNhap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSPNHAP);
            this.Controls.Add(this.dgvSPBAN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.ThongKe_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPBAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPNHAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSPBAN;
        private System.Windows.Forms.DataGridView dgvSPNHAP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTongSLNhap;
        private System.Windows.Forms.TextBox txtTongSPnhap;
        private System.Windows.Forms.TextBox txtTongSLBan;
        private System.Windows.Forms.TextBox txtTongSPban;
        private System.Windows.Forms.TextBox txtTongTienNhap;
        private System.Windows.Forms.TextBox txtTongTienBan;
        private System.Windows.Forms.TextBox txtTienLai;
        private System.Windows.Forms.Button btn_RELOAD;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.ComboBox cbbMonth;
    }
}