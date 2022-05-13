namespace QLBANXE
{
    partial class FeaturesProduct
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
            this.btn_Product = new System.Windows.Forms.Button();
            this.btn_HangXe = new System.Windows.Forms.Button();
            this.btn_NHACC = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_BANG_GIA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Product
            // 
            this.btn_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Product.Location = new System.Drawing.Point(135, 66);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(190, 91);
            this.btn_Product.TabIndex = 0;
            this.btn_Product.Text = "SẢN PHẨM";
            this.btn_Product.UseVisualStyleBackColor = true;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_HangXe
            // 
            this.btn_HangXe.Location = new System.Drawing.Point(135, 212);
            this.btn_HangXe.Name = "btn_HangXe";
            this.btn_HangXe.Size = new System.Drawing.Size(190, 87);
            this.btn_HangXe.TabIndex = 1;
            this.btn_HangXe.Text = "HÃNG XE";
            this.btn_HangXe.UseVisualStyleBackColor = true;
            this.btn_HangXe.Click += new System.EventHandler(this.btn_HangXe_Click);
            // 
            // btn_NHACC
            // 
            this.btn_NHACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NHACC.Location = new System.Drawing.Point(541, 66);
            this.btn_NHACC.Name = "btn_NHACC";
            this.btn_NHACC.Size = new System.Drawing.Size(176, 91);
            this.btn_NHACC.TabIndex = 2;
            this.btn_NHACC.Text = "NHÀ CUNG CẤP";
            this.btn_NHACC.UseVisualStyleBackColor = true;
            this.btn_NHACC.Click += new System.EventHandler(this.btn_NHACC_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(380, 313);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(105, 44);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_BANG_GIA
            // 
            this.btn_BANG_GIA.Location = new System.Drawing.Point(541, 212);
            this.btn_BANG_GIA.Name = "btn_BANG_GIA";
            this.btn_BANG_GIA.Size = new System.Drawing.Size(176, 87);
            this.btn_BANG_GIA.TabIndex = 4;
            this.btn_BANG_GIA.Text = "BẢNG GIÁ";
            this.btn_BANG_GIA.UseVisualStyleBackColor = true;
            this.btn_BANG_GIA.Click += new System.EventHandler(this.btn_BANG_GIA_Click);
            // 
            // FeaturesProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.btn_BANG_GIA);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_NHACC);
            this.Controls.Add(this.btn_HangXe);
            this.Controls.Add(this.btn_Product);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FeaturesProduct";
            this.Text = "FeaturesProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Button btn_HangXe;
        private System.Windows.Forms.Button btn_NHACC;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_BANG_GIA;
    }
}