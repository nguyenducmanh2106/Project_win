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
            this.label2 = new System.Windows.Forms.Label();
            this.DVT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TENHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SOLUONG = new System.Windows.Forms.NumericUpDown();
            this.MAHH = new System.Windows.Forms.TextBox();
            this.GIAXUAT = new System.Windows.Forms.MaskedTextBox();
            this.GIANHAP = new System.Windows.Forms.MaskedTextBox();
            this.HINHANH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SOLUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HINHANH)).BeginInit();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(143, 44);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(80, 13);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Mã hàng hóa(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn vị tính";
            // 
            // DVT
            // 
            this.DVT.Location = new System.Drawing.Point(233, 117);
            this.DVT.Name = "DVT";
            this.DVT.Size = new System.Drawing.Size(200, 20);
            this.DVT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên hàng hóa(*)";
            // 
            // TENHH
            // 
            this.TENHH.Location = new System.Drawing.Point(233, 79);
            this.TENHH.Name = "TENHH";
            this.TENHH.Size = new System.Drawing.Size(200, 20);
            this.TENHH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(190, 319);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(90, 35);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Hủy";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(297, 319);
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
            this.label3.Location = new System.Drawing.Point(143, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giá xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giá nhập";
            // 
            // SOLUONG
            // 
            this.SOLUONG.Location = new System.Drawing.Point(233, 158);
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Size = new System.Drawing.Size(200, 20);
            this.SOLUONG.TabIndex = 20;
            // 
            // MAHH
            // 
            this.MAHH.Location = new System.Drawing.Point(233, 41);
            this.MAHH.Name = "MAHH";
            this.MAHH.Size = new System.Drawing.Size(200, 20);
            this.MAHH.TabIndex = 1;
            // 
            // GIAXUAT
            // 
            this.GIAXUAT.Location = new System.Drawing.Point(233, 199);
            this.GIAXUAT.Name = "GIAXUAT";
            this.GIAXUAT.Size = new System.Drawing.Size(200, 20);
            this.GIAXUAT.TabIndex = 22;
            this.GIAXUAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.GIAXUAT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // GIANHAP
            // 
            this.GIANHAP.Location = new System.Drawing.Point(233, 238);
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Size = new System.Drawing.Size(200, 20);
            this.GIANHAP.TabIndex = 23;
            this.GIANHAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            this.GIANHAP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpGIANHAP);
            // 
            // HINHANH
            // 
            this.HINHANH.BackgroundImage = global::QLBANXE.Properties.Resources.icon_image_color_70;
            this.HINHANH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HINHANH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HINHANH.Location = new System.Drawing.Point(30, 44);
            this.HINHANH.Name = "HINHANH";
            this.HINHANH.Size = new System.Drawing.Size(100, 116);
            this.HINHANH.TabIndex = 24;
            this.HINHANH.TabStop = false;
            this.HINHANH.Click += new System.EventHandler(this.HINHANH_Click);
            // 
            // HangHoaCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 387);
            this.Controls.Add(this.HINHANH);
            this.Controls.Add(this.GIANHAP);
            this.Controls.Add(this.GIAXUAT);
            this.Controls.Add(this.SOLUONG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TENHH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DVT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MAHH);
            this.Controls.Add(this.CodeLabel);
            this.MaximizeBox = false;
            this.Name = "HangHoaCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới hàng hóa";
            this.Load += new System.EventHandler(this.HangHoaCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SOLUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HINHANH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label CodeLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DVT;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TENHH;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SOLUONG;
        public System.Windows.Forms.TextBox MAHH;
        private System.Windows.Forms.MaskedTextBox GIAXUAT;
        private System.Windows.Forms.MaskedTextBox GIANHAP;
        private System.Windows.Forms.PictureBox HINHANH;
    }
}