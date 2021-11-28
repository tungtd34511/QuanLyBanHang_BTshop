
namespace _3_GUI_PresentationLayer
{
    partial class frmThongTinKhachHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Diachi = new System.Windows.Forms.RichTextBox();
            this.rbtn_HoatDong = new System.Windows.Forms.RadioButton();
            this.rbtn_KhongHoatDong = new System.Windows.Forms.RadioButton();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.btn_Luu = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(320, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tình trạng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 432);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ:";
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(248, 432);
            this.txt_Diachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(688, 136);
            this.txt_Diachi.TabIndex = 7;
            this.txt_Diachi.Text = "";
            // 
            // rbtn_HoatDong
            // 
            this.rbtn_HoatDong.AutoSize = true;
            this.rbtn_HoatDong.Location = new System.Drawing.Point(248, 370);
            this.rbtn_HoatDong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtn_HoatDong.Name = "rbtn_HoatDong";
            this.rbtn_HoatDong.Size = new System.Drawing.Size(114, 27);
            this.rbtn_HoatDong.TabIndex = 8;
            this.rbtn_HoatDong.TabStop = true;
            this.rbtn_HoatDong.Text = "Hoạt động";
            this.rbtn_HoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtn_KhongHoatDong
            // 
            this.rbtn_KhongHoatDong.AutoSize = true;
            this.rbtn_KhongHoatDong.Location = new System.Drawing.Point(445, 368);
            this.rbtn_KhongHoatDong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtn_KhongHoatDong.Name = "rbtn_KhongHoatDong";
            this.rbtn_KhongHoatDong.Size = new System.Drawing.Size(166, 27);
            this.rbtn_KhongHoatDong.TabIndex = 9;
            this.rbtn_KhongHoatDong.TabStop = true;
            this.rbtn_KhongHoatDong.Text = "Không hoạt động";
            this.rbtn_KhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(248, 305);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(688, 30);
            this.txt_email.TabIndex = 10;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(248, 247);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(688, 30);
            this.txt_SDT.TabIndex = 11;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(248, 193);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(688, 30);
            this.txtTenKhachHang.TabIndex = 12;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(248, 136);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(688, 30);
            this.txtMaKhachHang.TabIndex = 13;
            // 
            // btn_Luu
            // 
            this.btn_Luu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Luu.IconColor = System.Drawing.Color.IndianRed;
            this.btn_Luu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Luu.IconSize = 25;
            this.btn_Luu.Location = new System.Drawing.Point(445, 604);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(118, 33);
            this.btn_Luu.TabIndex = 14;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // frmThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1000, 664);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.rbtn_KhongHoatDong);
            this.Controls.Add(this.rbtn_HoatDong);
            this.Controls.Add(this.txt_Diachi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmThongTinKhachHang";
            this.Text = "frmThongTinKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_Diachi;
        private System.Windows.Forms.RadioButton rbtn_HoatDong;
        private System.Windows.Forms.RadioButton rbtn_KhongHoatDong;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private FontAwesome.Sharp.IconButton btn_Luu;
    }
}