namespace QLBANXE
{
    partial class UserLoginInfor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.ChangePassWord = new System.Windows.Forms.Button();
            this.UpdateUserLogin = new System.Windows.Forms.Button();
            this.TENTK = new System.Windows.Forms.TextBox();
            this.TENDANGNHAP = new System.Windows.Forms.TextBox();
            this.TENTKTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.ChangePassWord);
            this.panel1.Controls.Add(this.UpdateUserLogin);
            this.panel1.Controls.Add(this.TENTK);
            this.panel1.Controls.Add(this.TENDANGNHAP);
            this.panel1.Controls.Add(this.TENTKTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 232);
            this.panel1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.Location = new System.Drawing.Point(359, 158);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(98, 36);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Thoát";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ChangePassWord
            // 
            this.ChangePassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePassWord.Location = new System.Drawing.Point(242, 158);
            this.ChangePassWord.Name = "ChangePassWord";
            this.ChangePassWord.Size = new System.Drawing.Size(98, 36);
            this.ChangePassWord.TabIndex = 6;
            this.ChangePassWord.Text = "Đổi mật khẩu";
            this.ChangePassWord.UseVisualStyleBackColor = true;
            this.ChangePassWord.Click += new System.EventHandler(this.ChangePassWord_Click);
            // 
            // UpdateUserLogin
            // 
            this.UpdateUserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateUserLogin.Location = new System.Drawing.Point(127, 158);
            this.UpdateUserLogin.Name = "UpdateUserLogin";
            this.UpdateUserLogin.Size = new System.Drawing.Size(98, 36);
            this.UpdateUserLogin.TabIndex = 5;
            this.UpdateUserLogin.Text = "Cập nhật";
            this.UpdateUserLogin.UseVisualStyleBackColor = true;
            this.UpdateUserLogin.Click += new System.EventHandler(this.UpdateUserLogin_Click);
            // 
            // TENTK
            // 
            this.TENTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TENTK.Location = new System.Drawing.Point(280, 54);
            this.TENTK.Name = "TENTK";
            this.TENTK.Size = new System.Drawing.Size(223, 20);
            this.TENTK.TabIndex = 4;
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TENDANGNHAP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TENDANGNHAP.Enabled = false;
            this.TENDANGNHAP.Location = new System.Drawing.Point(280, 15);
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.ReadOnly = true;
            this.TENDANGNHAP.Size = new System.Drawing.Size(223, 20);
            this.TENDANGNHAP.TabIndex = 3;
            // 
            // TENTKTitle
            // 
            this.TENTKTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TENTKTitle.AutoSize = true;
            this.TENTKTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TENTKTitle.Location = new System.Drawing.Point(123, 52);
            this.TENTKTitle.Name = "TENTKTitle";
            this.TENTKTitle.Size = new System.Drawing.Size(102, 22);
            this.TENTKTitle.TabIndex = 2;
            this.TENTKTitle.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // UserLoginInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 522);
            this.Controls.Add(this.panel1);
            this.Name = "UserLoginInfor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TENTKTitle;
        private System.Windows.Forms.TextBox TENDANGNHAP;
        private System.Windows.Forms.TextBox TENTK;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ChangePassWord;
        private System.Windows.Forms.Button UpdateUserLogin;
    }
}