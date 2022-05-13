namespace QLBANXE
{
    partial class HoaDon
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
            this.btn_HOA_DON_NHAP = new System.Windows.Forms.Button();
            this.btn_HOA_DON_BAN = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HOA_DON_NHAP
            // 
            this.btn_HOA_DON_NHAP.Location = new System.Drawing.Point(150, 59);
            this.btn_HOA_DON_NHAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_HOA_DON_NHAP.Name = "btn_HOA_DON_NHAP";
            this.btn_HOA_DON_NHAP.Size = new System.Drawing.Size(236, 102);
            this.btn_HOA_DON_NHAP.TabIndex = 0;
            this.btn_HOA_DON_NHAP.Text = "Hóa đơn nhập";
            this.btn_HOA_DON_NHAP.UseVisualStyleBackColor = true;
            this.btn_HOA_DON_NHAP.Click += new System.EventHandler(this.btn_HOA_DON_NHAP_Click);
            // 
            // btn_HOA_DON_BAN
            // 
            this.btn_HOA_DON_BAN.Location = new System.Drawing.Point(150, 203);
            this.btn_HOA_DON_BAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_HOA_DON_BAN.Name = "btn_HOA_DON_BAN";
            this.btn_HOA_DON_BAN.Size = new System.Drawing.Size(236, 98);
            this.btn_HOA_DON_BAN.TabIndex = 1;
            this.btn_HOA_DON_BAN.Text = "Hóa đơn bán";
            this.btn_HOA_DON_BAN.UseVisualStyleBackColor = true;
            this.btn_HOA_DON_BAN.Click += new System.EventHandler(this.btn_HOA_DON_BAN_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(150, 337);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(236, 91);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 461);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_HOA_DON_BAN);
            this.Controls.Add(this.btn_HOA_DON_NHAP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HOA_DON_NHAP;
        private System.Windows.Forms.Button btn_HOA_DON_BAN;
        private System.Windows.Forms.Button btn_thoat;
    }
}