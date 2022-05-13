namespace QLBANXE
{
    partial class HangTon
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
            this.dgvHangTon = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongslnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongslxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.txtTongSlNhap = new System.Windows.Forms.TextBox();
            this.txtTongSlXuat = new System.Windows.Forms.TextBox();
            this.txtSlCon = new System.Windows.Forms.TextBox();
            this.btn_SEARCH = new System.Windows.Forms.Button();
            this.btn_RELOAD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHangTon
            // 
            this.dgvHangTon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangTon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.tongslnhap,
            this.tongslxuat,
            this.slcon});
            this.dgvHangTon.Location = new System.Drawing.Point(88, 334);
            this.dgvHangTon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHangTon.Name = "dgvHangTon";
            this.dgvHangTon.RowHeadersWidth = 51;
            this.dgvHangTon.Size = new System.Drawing.Size(859, 128);
            this.dgvHangTon.TabIndex = 0;
            this.dgvHangTon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // tongslnhap
            // 
            this.tongslnhap.DataPropertyName = "slnhap";
            this.tongslnhap.HeaderText = "Tổng SL nhập";
            this.tongslnhap.MinimumWidth = 6;
            this.tongslnhap.Name = "tongslnhap";
            // 
            // tongslxuat
            // 
            this.tongslxuat.DataPropertyName = "slxuat";
            this.tongslxuat.HeaderText = "Tổng SL xuất";
            this.tongslxuat.MinimumWidth = 6;
            this.tongslxuat.Name = "tongslxuat";
            // 
            // slcon
            // 
            this.slcon.DataPropertyName = "slcon";
            this.slcon.HeaderText = "Số lượng còn";
            this.slcon.MinimumWidth = 6;
            this.slcon.Name = "slcon";
            // 
            // btn_thoat
            // 
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_thoat.Location = new System.Drawing.Point(491, 496);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(405, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "HÀNG TỒN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng sl nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng sl xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "số lượng còn";
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(375, 90);
            this.cbbMaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(304, 24);
            this.cbbMaSP.TabIndex = 7;
            // 
            // txtTongSlNhap
            // 
            this.txtTongSlNhap.Enabled = false;
            this.txtTongSlNhap.Location = new System.Drawing.Point(375, 134);
            this.txtTongSlNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongSlNhap.Name = "txtTongSlNhap";
            this.txtTongSlNhap.Size = new System.Drawing.Size(304, 22);
            this.txtTongSlNhap.TabIndex = 8;
            // 
            // txtTongSlXuat
            // 
            this.txtTongSlXuat.Enabled = false;
            this.txtTongSlXuat.Location = new System.Drawing.Point(375, 182);
            this.txtTongSlXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongSlXuat.Name = "txtTongSlXuat";
            this.txtTongSlXuat.Size = new System.Drawing.Size(304, 22);
            this.txtTongSlXuat.TabIndex = 9;
            // 
            // txtSlCon
            // 
            this.txtSlCon.Enabled = false;
            this.txtSlCon.Location = new System.Drawing.Point(375, 229);
            this.txtSlCon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSlCon.Name = "txtSlCon";
            this.txtSlCon.Size = new System.Drawing.Size(304, 22);
            this.txtSlCon.TabIndex = 10;
            // 
            // btn_SEARCH
            // 
            this.btn_SEARCH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SEARCH.Location = new System.Drawing.Point(375, 286);
            this.btn_SEARCH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SEARCH.Name = "btn_SEARCH";
            this.btn_SEARCH.Size = new System.Drawing.Size(132, 28);
            this.btn_SEARCH.TabIndex = 11;
            this.btn_SEARCH.Text = "Tìm theo mã sp";
            this.btn_SEARCH.UseVisualStyleBackColor = true;
            this.btn_SEARCH.Click += new System.EventHandler(this.btn_SEARCH_Click);
            // 
            // btn_RELOAD
            // 
            this.btn_RELOAD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_RELOAD.Location = new System.Drawing.Point(580, 286);
            this.btn_RELOAD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RELOAD.Name = "btn_RELOAD";
            this.btn_RELOAD.Size = new System.Drawing.Size(100, 28);
            this.btn_RELOAD.TabIndex = 12;
            this.btn_RELOAD.Text = "Reload";
            this.btn_RELOAD.UseVisualStyleBackColor = true;
            this.btn_RELOAD.Click += new System.EventHandler(this.btn_RELOAD_Click);
            // 
            // HangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_RELOAD);
            this.Controls.Add(this.btn_SEARCH);
            this.Controls.Add(this.txtSlCon);
            this.Controls.Add(this.txtTongSlXuat);
            this.Controls.Add(this.txtTongSlNhap);
            this.Controls.Add(this.cbbMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dgvHangTon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "HangTon";
            this.Text = "HangTon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.HangTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHangTon;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.TextBox txtTongSlNhap;
        private System.Windows.Forms.TextBox txtTongSlXuat;
        private System.Windows.Forms.TextBox txtSlCon;
        private System.Windows.Forms.Button btn_SEARCH;
        private System.Windows.Forms.Button btn_RELOAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongslnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongslxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn slcon;
    }
}