namespace TestSelenium
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rdTimKiem = new System.Windows.Forms.RadioButton();
            this.rdDangNhap = new System.Windows.Forms.RadioButton();
            this.rdGioHang = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ:";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(134, 29);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(269, 29);
            this.txtUrl.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Location = new System.Drawing.Point(267, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 43);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Bắt đầu chạy";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdTimKiem
            // 
            this.rdTimKiem.AutoSize = true;
            this.rdTimKiem.Checked = true;
            this.rdTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTimKiem.Location = new System.Drawing.Point(114, 79);
            this.rdTimKiem.Name = "rdTimKiem";
            this.rdTimKiem.Size = new System.Drawing.Size(144, 23);
            this.rdTimKiem.TabIndex = 3;
            this.rdTimKiem.TabStop = true;
            this.rdTimKiem.Text = "Tìm kiếm sản phẩm";
            this.rdTimKiem.UseVisualStyleBackColor = true;
            // 
            // rdDangNhap
            // 
            this.rdDangNhap.AutoSize = true;
            this.rdDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDangNhap.Location = new System.Drawing.Point(279, 79);
            this.rdDangNhap.Name = "rdDangNhap";
            this.rdDangNhap.Size = new System.Drawing.Size(92, 23);
            this.rdDangNhap.TabIndex = 3;
            this.rdDangNhap.Text = "Đăng nhập";
            this.rdDangNhap.UseVisualStyleBackColor = true;
            // 
            // rdGioHang
            // 
            this.rdGioHang.AutoSize = true;
            this.rdGioHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGioHang.Location = new System.Drawing.Point(404, 79);
            this.rdGioHang.Name = "rdGioHang";
            this.rdGioHang.Size = new System.Drawing.Size(166, 23);
            this.rdGioHang.TabIndex = 3;
            this.rdGioHang.Text = "Chọn cho vào giỏ hàng";
            this.rdGioHang.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 261);
            this.Controls.Add(this.rdGioHang);
            this.Controls.Add(this.rdDangNhap);
            this.Controls.Add(this.rdTimKiem);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rdTimKiem;
        private System.Windows.Forms.RadioButton rdDangNhap;
        private System.Windows.Forms.RadioButton rdGioHang;
    }
}

