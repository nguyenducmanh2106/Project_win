namespace QLBANXE
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
            this.MATKLabel.Location = new System.Drawing.Point(112, 44);
            this.MATKLabel.Name = "MATKLabel";
            this.MATKLabel.Size = new System.Drawing.Size(91, 13);
            this.MATKLabel.TabIndex = 0;
            this.MATKLabel.Text = "Tên đăng nhập(*)";
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Location = new System.Drawing.Point(224, 41);
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.Size = new System.Drawing.Size(121, 20);
            this.TENDANGNHAP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
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
            this.CAPTK.Location = new System.Drawing.Point(224, 134);
            this.CAPTK.Name = "CAPTK";
            this.CAPTK.Size = new System.Drawing.Size(121, 21);
            this.CAPTK.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Họ tên(*)";
            // 
            // TENTK
            // 
            this.TENTK.Location = new System.Drawing.Point(224, 84);
            this.TENTK.Name = "TENTK";
            this.TENTK.Size = new System.Drawing.Size(121, 20);
            this.TENTK.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(181, 319);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(90, 35);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Hủy";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(288, 319);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 35);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.AutoSize = true;
            this.TRANGTHAI.Location = new System.Drawing.Point(224, 178);
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Size = new System.Drawing.Size(73, 17);
            this.TRANGTHAI.TabIndex = 14;
            this.TRANGTHAI.Text = "Kích hoạt";
            this.TRANGTHAI.UseVisualStyleBackColor = true;
            // 
            // DanhMucTaiKhoanBoxUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 387);
            this.Controls.Add(this.TRANGTHAI);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TENTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CAPTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TENDANGNHAP);
            this.Controls.Add(this.MATKLabel);
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