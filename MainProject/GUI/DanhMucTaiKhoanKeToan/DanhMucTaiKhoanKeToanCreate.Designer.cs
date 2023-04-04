namespace KETOANDOANHTHU
{
    partial class DanhMucTaiKhoanKeToanCreate
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
            this.MATK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CAPTK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TENTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TKCT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MATKLabel
            // 
            this.MATKLabel.AutoSize = true;
            this.MATKLabel.Location = new System.Drawing.Point(168, 68);
            this.MATKLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MATKLabel.Name = "MATKLabel";
            this.MATKLabel.Size = new System.Drawing.Size(116, 20);
            this.MATKLabel.TabIndex = 0;
            this.MATKLabel.Text = "Mã tài khoản(*)";
            // 
            // MATK
            // 
            this.MATK.Location = new System.Drawing.Point(336, 63);
            this.MATK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MATK.Name = "MATK";
            this.MATK.Size = new System.Drawing.Size(180, 26);
            this.MATK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 268);
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
            "4",
            "5"});
            this.CAPTK.Location = new System.Drawing.Point(336, 255);
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
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên tài khoản(*)";
            // 
            // TENTK
            // 
            this.TENTK.Location = new System.Drawing.Point(336, 129);
            this.TENTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TENTK.Name = "TENTK";
            this.TENTK.Size = new System.Drawing.Size(180, 26);
            this.TENTK.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tài khoản cấp trên";
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
            // TKCT
            // 
            this.TKCT.FormattingEnabled = true;
            this.TKCT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.TKCT.Location = new System.Drawing.Point(336, 192);
            this.TKCT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TKCT.Name = "TKCT";
            this.TKCT.Size = new System.Drawing.Size(180, 28);
            this.TKCT.TabIndex = 15;
            // 
            // DanhMucTaiKhoanKeToanCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 595);
            this.Controls.Add(this.TKCT);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TENTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CAPTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MATK);
            this.Controls.Add(this.MATKLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DanhMucTaiKhoanKeToanCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới tài khoản";
            this.Load += new System.EventHandler(this.DanhMucTaiKhoanKeToanCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label MATKLabel;
        public System.Windows.Forms.TextBox MATK;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CAPTK;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TENTK;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.ComboBox TKCT;
    }
}