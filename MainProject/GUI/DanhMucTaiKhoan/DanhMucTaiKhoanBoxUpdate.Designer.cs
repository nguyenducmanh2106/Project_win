namespace KETOANDOANHTHU
{
    partial class DanhMucTaiKhoanBoxUpdate
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
            this.MATKLabel = new System.Windows.Forms.Label();
            this.TENDANGNHAP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CAPTK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TENTK = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TRANGTHAI = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MATKLabel
            // 
            this.MATKLabel.AutoSize = true;
            this.MATKLabel.Location = new System.Drawing.Point(168, 68);
            this.MATKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MATKLabel.Name = "MATKLabel";
            this.MATKLabel.Size = new System.Drawing.Size(132, 20);
            this.MATKLabel.TabIndex = 0;
            this.MATKLabel.Text = "Tên đăng nhập(*)";
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Enabled = false;
            this.TENDANGNHAP.Location = new System.Drawing.Point(336, 63);
            this.TENDANGNHAP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.ReadOnly = true;
            this.TENDANGNHAP.Size = new System.Drawing.Size(180, 26);
            this.TENDANGNHAP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cấp tài khoản";
            // 
            // CAPTK
            // 
            this.CAPTK.FormattingEnabled = true;
            this.CAPTK.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CAPTK.Location = new System.Drawing.Point(336, 206);
            this.CAPTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CAPTK.Name = "CAPTK";
            this.CAPTK.Size = new System.Drawing.Size(180, 28);
            this.CAPTK.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Họ tên(*)";
            // 
            // TENTK
            // 
            this.TENTK.Location = new System.Drawing.Point(336, 129);
            this.TENTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TENTK.Name = "TENTK";
            this.TENTK.Size = new System.Drawing.Size(180, 26);
            this.TENTK.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(272, 491);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(135, 54);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Hủy";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(432, 491);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(135, 54);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AutoSize = true;
            this.TRANGTHAI.Location = new System.Drawing.Point(336, 274);
            this.TRANGTHAI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Size = new System.Drawing.Size(94, 24);
            this.TRANGTHAI.TabIndex = 14;
            this.TRANGTHAI.Text = "Kích hoạt";
            this.TRANGTHAI.UseVisualStyleBackColor = true;
            // 
            // DanhMucTaiKhoanBoxUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 595);
            this.Controls.Add(this.TRANGTHAI);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TENTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CAPTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TENDANGNHAP);
            this.Controls.Add(this.MATKLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DanhMucTaiKhoanBoxUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label MATKLabel;
        public System.Windows.Forms.TextBox TENDANGNHAP;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CAPTK;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TENTK;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.CheckBox TRANGTHAI;
    }
}