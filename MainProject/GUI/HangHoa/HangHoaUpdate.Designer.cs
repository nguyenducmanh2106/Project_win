namespace QLBANXE
{
    partial class HangHoaUpdate
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MAHH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(101, 83);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(80, 13);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Mã hàng hóa(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn vị tính";
            // 
            // DVT
            // 
            this.DVT.Location = new System.Drawing.Point(191, 156);
            this.DVT.Name = "DVT";
            this.DVT.Size = new System.Drawing.Size(229, 20);
            this.DVT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên hàng hóa(*)";
            // 
            // TENHH
            // 
            this.TENHH.Location = new System.Drawing.Point(191, 118);
            this.TENHH.Name = "TENHH";
            this.TENHH.Size = new System.Drawing.Size(229, 20);
            this.TENHH.TabIndex = 9;
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
            // MAHH
            // 
            this.MAHH.Location = new System.Drawing.Point(191, 80);
            this.MAHH.Name = "MAHH";
            this.MAHH.Size = new System.Drawing.Size(229, 20);
            this.MAHH.TabIndex = 1;
            // 
            // HangHoaUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 387);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TENHH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DVT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MAHH);
            this.Controls.Add(this.CodeLabel);
            this.MaximizeBox = false;
            this.Name = "HangHoaUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật hàng hóa";
            this.Load += new System.EventHandler(this.HangHoaUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label CodeLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DVT;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TENHH;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.TextBox MAHH;
    }
}