namespace QLBANXE
{
    partial class MainScreen
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
            this.btn_QLSANPHAM = new System.Windows.Forms.Button();
            this.btn_KHACH_HANG = new System.Windows.Forms.Button();
            this.btn_HANG_TON = new System.Windows.Forms.Button();
            this.btn_HOA_DON = new System.Windows.Forms.Button();
            this.btn_THONG_KE = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QLSANPHAM
            // 
            this.btn_QLSANPHAM.Location = new System.Drawing.Point(92, 52);
            this.btn_QLSANPHAM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_QLSANPHAM.Name = "btn_QLSANPHAM";
            this.btn_QLSANPHAM.Size = new System.Drawing.Size(187, 84);
            this.btn_QLSANPHAM.TabIndex = 0;
            this.btn_QLSANPHAM.Text = "QUẢN LÝ SẢN PHẨM";
            this.btn_QLSANPHAM.UseVisualStyleBackColor = true;
            this.btn_QLSANPHAM.Click += new System.EventHandler(this.btn_QLSANPHAM_Click);
            // 
            // btn_KHACH_HANG
            // 
            this.btn_KHACH_HANG.Location = new System.Drawing.Point(92, 178);
            this.btn_KHACH_HANG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_KHACH_HANG.Name = "btn_KHACH_HANG";
            this.btn_KHACH_HANG.Size = new System.Drawing.Size(187, 82);
            this.btn_KHACH_HANG.TabIndex = 1;
            this.btn_KHACH_HANG.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.btn_KHACH_HANG.UseVisualStyleBackColor = true;
            this.btn_KHACH_HANG.Click += new System.EventHandler(this.btn_KHACH_HANG_Click);
            // 
            // btn_HANG_TON
            // 
            this.btn_HANG_TON.Location = new System.Drawing.Point(92, 290);
            this.btn_HANG_TON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_HANG_TON.Name = "btn_HANG_TON";
            this.btn_HANG_TON.Size = new System.Drawing.Size(187, 84);
            this.btn_HANG_TON.TabIndex = 2;
            this.btn_HANG_TON.Text = "QUẢN LÝ HÀNG TỒN";
            this.btn_HANG_TON.UseVisualStyleBackColor = true;
            this.btn_HANG_TON.Click += new System.EventHandler(this.btn_HANG_TON_Click);
            // 
            // btn_HOA_DON
            // 
            this.btn_HOA_DON.Location = new System.Drawing.Point(406, 52);
            this.btn_HOA_DON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_HOA_DON.Name = "btn_HOA_DON";
            this.btn_HOA_DON.Size = new System.Drawing.Size(192, 84);
            this.btn_HOA_DON.TabIndex = 4;
            this.btn_HOA_DON.Text = "QUẢN LÝ HÓA ĐƠN";
            this.btn_HOA_DON.UseVisualStyleBackColor = true;
            this.btn_HOA_DON.Click += new System.EventHandler(this.btn_HOA_DON_Click);
            // 
            // btn_THONG_KE
            // 
            this.btn_THONG_KE.Location = new System.Drawing.Point(406, 178);
            this.btn_THONG_KE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_THONG_KE.Name = "btn_THONG_KE";
            this.btn_THONG_KE.Size = new System.Drawing.Size(192, 82);
            this.btn_THONG_KE.TabIndex = 5;
            this.btn_THONG_KE.Text = "THỐNG KÊ";
            this.btn_THONG_KE.UseVisualStyleBackColor = true;
            this.btn_THONG_KE.Click += new System.EventHandler(this.btn_THONG_KE_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(406, 290);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(192, 84);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Đăng xuất";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 421);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_THONG_KE);
            this.Controls.Add(this.btn_HOA_DON);
            this.Controls.Add(this.btn_HANG_TON);
            this.Controls.Add(this.btn_KHACH_HANG);
            this.Controls.Add(this.btn_QLSANPHAM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QLSANPHAM;
        private System.Windows.Forms.Button btn_KHACH_HANG;
        private System.Windows.Forms.Button btn_HANG_TON;
        private System.Windows.Forms.Button btn_HOA_DON;
        private System.Windows.Forms.Button btn_THONG_KE;
        private System.Windows.Forms.Button btn_Thoat;
    }
}