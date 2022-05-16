namespace QLBANXE
{
    partial class HangHoaCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TENHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NGAYDANGKY = new System.Windows.Forms.DateTimePicker();
            this.SOLUONG = new System.Windows.Forms.NumericUpDown();
            this.MANCC = new System.Windows.Forms.ComboBox();
            this.MAHH = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SOLUONG)).BeginInit();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(112, 44);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(80, 13);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Mã hàng hóa(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn vị tính";
            // 
            // DVT
            // 
            this.DVT.Location = new System.Drawing.Point(224, 117);
            this.DVT.Name = "DVT";
            this.DVT.Size = new System.Drawing.Size(200, 20);
            this.DVT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên hàng hóa(*)";
            // 
            // TENHH
            // 
            this.TENHH.Location = new System.Drawing.Point(224, 79);
            this.TENHH.Name = "TENHH";
            this.TENHH.Size = new System.Drawing.Size(200, 20);
            this.TENHH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giá xuất";
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
            // SOLUONG
            // 
            this.SOLUONG.Location = new System.Drawing.Point(224, 158);
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Size = new System.Drawing.Size(200, 20);
            this.SOLUONG.TabIndex = 20;
            // 
            // MANCC
            // 
            this.MANCC.FormattingEnabled = true;
            this.MANCC.Location = new System.Drawing.Point(224, 195);
            this.MANCC.Name = "MANCC";
            this.MANCC.Size = new System.Drawing.Size(200, 21);
            this.MANCC.TabIndex = 21;
            // 
            // MAHH
            // 
            this.MAHH.Location = new System.Drawing.Point(224, 41);
            this.MAHH.Name = "MAHH";
            this.MAHH.Size = new System.Drawing.Size(200, 20);
            this.MAHH.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // HangHoaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 387);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MANCC);
            this.Controls.Add(this.SOLUONG);
            this.Controls.Add(this.NGAYDANGKY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TENHH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DVT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MAHH);
            this.Controls.Add(this.CodeLabel);
            this.MaximizeBox = false;
            this.Name = "HangHoaCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.SOLUONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label CodeLabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DVT;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TENHH;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker NGAYDANGKY;
        private System.Windows.Forms.NumericUpDown SOLUONG;
        private System.Windows.Forms.ComboBox MANCC;
        public System.Windows.Forms.TextBox MAHH;
        private System.Windows.Forms.MaskedTextBox textBox1;
    }
}