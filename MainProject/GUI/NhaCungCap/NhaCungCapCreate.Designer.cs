namespace KETOANDOANHTHU
{
    partial class NhaCungCapCreate
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
            this.MANCCLabel = new System.Windows.Forms.Label();
            this.MANCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DIACHI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TENNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NGUNGHOPTAC = new System.Windows.Forms.CheckBox();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // MANCCLabel
            // 
            this.MANCCLabel.AutoSize = true;
            this.MANCCLabel.Location = new System.Drawing.Point(112, 44);
            this.MANCCLabel.Name = "MANCCLabel";
            this.MANCCLabel.Size = new System.Drawing.Size(57, 13);
            this.MANCCLabel.TabIndex = 0;
            this.MANCCLabel.Text = "Mã NCC(*)";
            // 
            // MANCC
            // 
            this.MANCC.Location = new System.Drawing.Point(224, 41);
            this.MANCC.Name = "MANCC";
            this.MANCC.Size = new System.Drawing.Size(200, 20);
            this.MANCC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ";
            // 
            // DIACHI
            // 
            this.DIACHI.Location = new System.Drawing.Point(224, 132);
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Size = new System.Drawing.Size(200, 20);
            this.DIACHI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên NCC(*)";
            // 
            // TENNCC
            // 
            this.TENNCC.Location = new System.Drawing.Point(224, 84);
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Size = new System.Drawing.Size(200, 20);
            this.TENNCC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 180);
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
            // NGUNGHOPTAC
            // 
            this.NGUNGHOPTAC.AutoSize = true;
            this.NGUNGHOPTAC.Location = new System.Drawing.Point(224, 262);
            this.NGUNGHOPTAC.Name = "NGUNGHOPTAC";
            this.NGUNGHOPTAC.Size = new System.Drawing.Size(97, 17);
            this.NGUNGHOPTAC.TabIndex = 14;
            this.NGUNGHOPTAC.Text = "Ngừng hợp tác";
            this.NGUNGHOPTAC.UseVisualStyleBackColor = true;
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(224, 219);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(200, 20);
            this.EMAIL.TabIndex = 15;
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(224, 173);
            this.SDT.Mask = "0000000000";
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(200, 20);
            this.SDT.TabIndex = 26;
            // 
            // NhaCungCapCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 387);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.NGUNGHOPTAC);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TENNCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DIACHI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MANCC);
            this.Controls.Add(this.MANCCLabel);
            this.MaximizeBox = false;
            this.Name = "NhaCungCapCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới nhà cung cấp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label MANCCLabel;
        public System.Windows.Forms.TextBox MANCC;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DIACHI;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TENNCC;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.CheckBox NGUNGHOPTAC;
        public System.Windows.Forms.TextBox EMAIL;
        public System.Windows.Forms.MaskedTextBox SDT;
    }
}