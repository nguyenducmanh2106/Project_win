namespace KETOANDOANHTHU
{
    partial class KhachHangCreate
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
            this.CodeLabel = new System.Windows.Forms.Label();
            this.MAKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DIACHI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TENKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NGAYDANGKY = new System.Windows.Forms.DateTimePicker();
            this.SDT = new System.Windows.Forms.MaskedTextBox();
            this.MST = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(112, 44);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(50, 13);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Mã KH(*)";
            // 
            // MAKH
            // 
            this.MAKH.Location = new System.Drawing.Point(224, 41);
            this.MAKH.Name = "MAKH";
            this.MAKH.Size = new System.Drawing.Size(200, 20);
            this.MAKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ";
            // 
            // DIACHI
            // 
            this.DIACHI.Location = new System.Drawing.Point(224, 117);
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Size = new System.Drawing.Size(200, 20);
            this.DIACHI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên KH(*)";
            // 
            // TENKH
            // 
            this.TENKH.Location = new System.Drawing.Point(224, 79);
            this.TENKH.Name = "TENKH";
            this.TENKH.Size = new System.Drawing.Size(200, 20);
            this.TENKH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SĐT";
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
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(224, 196);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(200, 20);
            this.EMAIL.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã số thuế";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ngày đăng ký(*)";
            // 
            // NGAYDANGKY
            // 
            this.NGAYDANGKY.CustomFormat = "dd/MM/yyyy";
            this.NGAYDANGKY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NGAYDANGKY.Location = new System.Drawing.Point(224, 269);
            this.NGAYDANGKY.Name = "NGAYDANGKY";
            this.NGAYDANGKY.Size = new System.Drawing.Size(200, 20);
            this.NGAYDANGKY.TabIndex = 19;
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(224, 157);
            this.SDT.Mask = "0000000000";
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(200, 20);
            this.SDT.TabIndex = 20;
            // 
            // MST
            // 
            this.MST.Location = new System.Drawing.Point(224, 236);
            this.MST.Mask = "0000000000";
            this.MST.Name = "MST";
            this.MST.Size = new System.Drawing.Size(200, 20);
            this.MST.TabIndex = 21;
            // 
            // KhachHangCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 387);
            this.Controls.Add(this.MST);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.NGAYDANGKY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TENKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DIACHI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MAKH);
            this.Controls.Add(this.CodeLabel);
            this.MaximizeBox = false;
            this.Name = "KhachHangCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label CodeLabel;
        public System.Windows.Forms.TextBox MAKH;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DIACHI;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TENKH;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.TextBox EMAIL;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker NGAYDANGKY;
        public System.Windows.Forms.MaskedTextBox SDT;
        public System.Windows.Forms.MaskedTextBox MST;
    }
}