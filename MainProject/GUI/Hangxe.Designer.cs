namespace QLBANXE
{
    partial class Hangxe
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
            this.tbMaHangXe = new System.Windows.Forms.TextBox();
            this.tbTenXe = new System.Windows.Forms.TextBox();
            this.dgvHangXe = new System.Windows.Forms.DataGridView();
            this.Mahangxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(315, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÃNG XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hãng xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hãng xe";
            // 
            // tbMaHangXe
            // 
            this.tbMaHangXe.Location = new System.Drawing.Point(286, 118);
            this.tbMaHangXe.Name = "tbMaHangXe";
            this.tbMaHangXe.Size = new System.Drawing.Size(134, 20);
            this.tbMaHangXe.TabIndex = 3;
            // 
            // tbTenXe
            // 
            this.tbTenXe.Location = new System.Drawing.Point(286, 183);
            this.tbTenXe.Name = "tbTenXe";
            this.tbTenXe.Size = new System.Drawing.Size(134, 20);
            this.tbTenXe.TabIndex = 4;
            // 
            // dgvHangXe
            // 
            this.dgvHangXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahangxe,
            this.Tenhang});
            this.dgvHangXe.Location = new System.Drawing.Point(94, 253);
            this.dgvHangXe.Name = "dgvHangXe";
            this.dgvHangXe.Size = new System.Drawing.Size(432, 141);
            this.dgvHangXe.TabIndex = 5;
            this.dgvHangXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // Mahangxe
            // 
            this.Mahangxe.DataPropertyName = "Mahangxe";
            this.Mahangxe.HeaderText = "Mã hãng xe";
            this.Mahangxe.Name = "Mahangxe";
            // 
            // Tenhang
            // 
            this.Tenhang.DataPropertyName = "Tenhang";
            this.Tenhang.HeaderText = "Tên hãng xe";
            this.Tenhang.Name = "Tenhang";
            this.Tenhang.Width = 200;
            // 
            // btn_thoat
            // 
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_thoat.Location = new System.Drawing.Point(371, 415);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(84, 28);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_ADD
            // 
            this.btn_ADD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ADD.Location = new System.Drawing.Point(577, 83);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(109, 48);
            this.btn_ADD.TabIndex = 7;
            this.btn_ADD.Text = "Thêm";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Update.Location = new System.Drawing.Point(577, 151);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(109, 45);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Delete.Location = new System.Drawing.Point(577, 215);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(109, 47);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Search.Location = new System.Drawing.Point(577, 283);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(109, 46);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Reload.Location = new System.Drawing.Point(577, 346);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(109, 48);
            this.btn_Reload.TabIndex = 11;
            this.btn_Reload.Text = "Reload";
            this.btn_Reload.UseVisualStyleBackColor = true;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // Hangxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dgvHangXe);
            this.Controls.Add(this.tbTenXe);
            this.Controls.Add(this.tbMaHangXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hangxe";
            this.Text = "Hangxe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.Hangxe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaHangXe;
        private System.Windows.Forms.TextBox tbTenXe;
        private System.Windows.Forms.DataGridView dgvHangXe;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahangxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenhang;
        private System.Windows.Forms.Button btn_Reload;
    }
}