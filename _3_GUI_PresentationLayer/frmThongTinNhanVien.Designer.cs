
namespace _3_GUI_PresentationLayer
{
    partial class frmThongTinNhanVien
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.img_NhanVien = new System.Windows.Forms.PictureBox();
            this.rbtn_KhongHoatDong = new System.Windows.Forms.RadioButton();
            this.rbtn_HoatDong = new System.Windows.Forms.RadioButton();
            this.btn_linkIMG = new System.Windows.Forms.Button();
            this.txt_anh = new System.Windows.Forms.RichTextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Phai = new System.Windows.Forms.ComboBox();
            this.txt_ChucVu = new System.Windows.Forms.ComboBox();
            this.txt_GhiCHu = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.img_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(465, 564);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(114, 29);
            this.btn_Luu.TabIndex = 72;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 69;
            this.label13.Text = "Ghi chú:";
            // 
            // img_NhanVien
            // 
            this.img_NhanVien.BackColor = System.Drawing.SystemColors.HotTrack;
            this.img_NhanVien.Location = new System.Drawing.Point(652, 343);
            this.img_NhanVien.Name = "img_NhanVien";
            this.img_NhanVien.Size = new System.Drawing.Size(240, 190);
            this.img_NhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_NhanVien.TabIndex = 68;
            this.img_NhanVien.TabStop = false;
            // 
            // rbtn_KhongHoatDong
            // 
            this.rbtn_KhongHoatDong.AutoSize = true;
            this.rbtn_KhongHoatDong.Location = new System.Drawing.Point(764, 180);
            this.rbtn_KhongHoatDong.Name = "rbtn_KhongHoatDong";
            this.rbtn_KhongHoatDong.Size = new System.Drawing.Size(146, 24);
            this.rbtn_KhongHoatDong.TabIndex = 67;
            this.rbtn_KhongHoatDong.TabStop = true;
            this.rbtn_KhongHoatDong.Text = "Không hoạt động";
            this.rbtn_KhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtn_HoatDong
            // 
            this.rbtn_HoatDong.AutoSize = true;
            this.rbtn_HoatDong.Location = new System.Drawing.Point(652, 182);
            this.rbtn_HoatDong.Name = "rbtn_HoatDong";
            this.rbtn_HoatDong.Size = new System.Drawing.Size(102, 24);
            this.rbtn_HoatDong.TabIndex = 66;
            this.rbtn_HoatDong.TabStop = true;
            this.rbtn_HoatDong.Text = "Hoạt động";
            this.rbtn_HoatDong.UseVisualStyleBackColor = true;
            // 
            // btn_linkIMG
            // 
            this.btn_linkIMG.Location = new System.Drawing.Point(547, 241);
            this.btn_linkIMG.Name = "btn_linkIMG";
            this.btn_linkIMG.Size = new System.Drawing.Size(79, 29);
            this.btn_linkIMG.TabIndex = 65;
            this.btn_linkIMG.Text = "Link ảnh";
            this.btn_linkIMG.UseVisualStyleBackColor = true;
            this.btn_linkIMG.Click += new System.EventHandler(this.btn_linkIMG_Click);
            // 
            // txt_anh
            // 
            this.txt_anh.Location = new System.Drawing.Point(652, 219);
            this.txt_anh.Name = "txt_anh";
            this.txt_anh.Size = new System.Drawing.Size(240, 69);
            this.txt_anh.TabIndex = 62;
            this.txt_anh.Text = "";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(652, 99);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(240, 77);
            this.txt_DiaChi.TabIndex = 60;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(652, 61);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(240, 27);
            this.txt_SoDienThoai.TabIndex = 59;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(652, 24);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(240, 27);
            this.txt_email.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(652, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 20);
            this.label14.TabIndex = 57;
            this.label14.Text = "Ảnh:";
            // 
            // txt_Phai
            // 
            this.txt_Phai.FormattingEnabled = true;
            this.txt_Phai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txt_Phai.Location = new System.Drawing.Point(432, 241);
            this.txt_Phai.Name = "txt_Phai";
            this.txt_Phai.Size = new System.Drawing.Size(94, 28);
            this.txt_Phai.TabIndex = 56;
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.FormattingEnabled = true;
            this.txt_ChucVu.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.txt_ChucVu.Location = new System.Drawing.Point(286, 241);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(83, 28);
            this.txt_ChucVu.TabIndex = 55;
            // 
            // txt_GhiCHu
            // 
            this.txt_GhiCHu.Location = new System.Drawing.Point(169, 343);
            this.txt_GhiCHu.Name = "txt_GhiCHu";
            this.txt_GhiCHu.Size = new System.Drawing.Size(445, 190);
            this.txt_GhiCHu.TabIndex = 54;
            this.txt_GhiCHu.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Phái:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Chức vụ:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(286, 61);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(240, 27);
            this.txt_TenNhanVien.TabIndex = 51;
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(286, 24);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(240, 27);
            this.txt_MaNhanVien.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Tình trạng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Địa chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã Nhân viên:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tên Nhân viên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ngày sinh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Location = new System.Drawing.Point(286, 179);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(240, 27);
            this.txt_NgaySinh.TabIndex = 73;
            this.txt_NgaySinh.Value = new System.DateTime(2021, 11, 15, 0, 0, 0, 0);
            // 
            // frmThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1060, 617);
            this.Controls.Add(this.txt_NgaySinh);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.img_NhanVien);
            this.Controls.Add(this.rbtn_KhongHoatDong);
            this.Controls.Add(this.rbtn_HoatDong);
            this.Controls.Add(this.btn_linkIMG);
            this.Controls.Add(this.txt_anh);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Phai);
            this.Controls.Add(this.txt_ChucVu);
            this.Controls.Add(this.txt_GhiCHu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_TenNhanVien);
            this.Controls.Add(this.txt_MaNhanVien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmThongTinNhanVien";
            this.Text = "frmThongTinNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.img_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox img_NhanVien;
        private System.Windows.Forms.RadioButton rbtn_KhongHoatDong;
        private System.Windows.Forms.RadioButton rbtn_HoatDong;
        private System.Windows.Forms.Button btn_linkIMG;
        private System.Windows.Forms.RichTextBox txt_anh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox txt_Phai;
        private System.Windows.Forms.ComboBox txt_ChucVu;
        private System.Windows.Forms.RichTextBox txt_GhiCHu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_NgaySinh;
    }
}