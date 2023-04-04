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
            this.MANCCLabel.Location = new System.Drawing.Point(168, 68);
            this.MANCCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MANCCLabel.Name = "MANCCLabel";
            this.MANCCLabel.Size = new System.Drawing.Size(84, 20);
            this.MANCCLabel.TabIndex = 0;
            this.MANCCLabel.Text = "Mã NCC(*)";
            // 
            // MANCC
            // 
            this.MANCC.Location = new System.Drawing.Point(336, 63);
            this.MANCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MANCC.Name = "MANCC";
            this.MANCC.Size = new System.Drawing.Size(298, 26);
            this.MANCC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa chỉ";
            // 
            // DIACHI
            // 
            this.DIACHI.Location = new System.Drawing.Point(336, 203);
            this.DIACHI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Size = new System.Drawing.Size(298, 26);
            this.DIACHI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên NCC(*)";
            // 
            // TENNCC
            // 
            this.TENNCC.Location = new System.Drawing.Point(336, 129);
            this.TENNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Size = new System.Drawing.Size(298, 26);
            this.TENNCC.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SĐT";
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
            // NGUNGHOPTAC
            // 
            this.NGUNGHOPTAC.AutoSize = true;
            this.NGUNGHOPTAC.Location = new System.Drawing.Point(336, 403);
            this.NGUNGHOPTAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NGUNGHOPTAC.Name = "NGUNGHOPTAC";
            this.NGUNGHOPTAC.Size = new System.Drawing.Size(132, 24);
            this.NGUNGHOPTAC.TabIndex = 14;
            this.NGUNGHOPTAC.Text = "Ngừng hợp tác";
            this.NGUNGHOPTAC.UseVisualStyleBackColor = true;
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(336, 337);
            this.EMAIL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(298, 26);
            this.EMAIL.TabIndex = 15;
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(336, 266);
            this.SDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SDT.Mask = "0000000000";
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(298, 26);
            this.SDT.TabIndex = 26;
            // 
            // NhaCungCapCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 595);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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