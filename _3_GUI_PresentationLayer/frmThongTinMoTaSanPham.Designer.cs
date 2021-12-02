
namespace _3_GUI_PresentationLayer
{
    partial class frmThongTinMoTaSanPham
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
            this.txt_DungTich = new System.Windows.Forms.TextBox();
            this.txt_PhienBan = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_anh = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.rbtn_nam = new System.Windows.Forms.RadioButton();
            this.rbtn_nu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_DungTich
            // 
            this.txt_DungTich.Location = new System.Drawing.Point(626, 141);
            this.txt_DungTich.Name = "txt_DungTich";
            this.txt_DungTich.Size = new System.Drawing.Size(240, 27);
            this.txt_DungTich.TabIndex = 37;
            // 
            // txt_PhienBan
            // 
            this.txt_PhienBan.Location = new System.Drawing.Point(626, 99);
            this.txt_PhienBan.Name = "txt_PhienBan";
            this.txt_PhienBan.Size = new System.Drawing.Size(240, 27);
            this.txt_PhienBan.TabIndex = 36;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(172, 96);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(267, 27);
            this.txt_Id.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ảnh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ghi Chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Phiên bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Phái";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Dung Tích(ml):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_anh
            // 
            this.txt_anh.Location = new System.Drawing.Point(113, 226);
            this.txt_anh.Multiline = true;
            this.txt_anh.Name = "txt_anh";
            this.txt_anh.Size = new System.Drawing.Size(326, 133);
            this.txt_anh.TabIndex = 27;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(411, 394);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(94, 29);
            this.btn_Luu.TabIndex = 39;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(509, 226);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(357, 133);
            this.txt_ghichu.TabIndex = 40;
            // 
            // rbtn_nam
            // 
            this.rbtn_nam.AutoSize = true;
            this.rbtn_nam.Checked = true;
            this.rbtn_nam.Location = new System.Drawing.Point(172, 146);
            this.rbtn_nam.Name = "rbtn_nam";
            this.rbtn_nam.Size = new System.Drawing.Size(62, 24);
            this.rbtn_nam.TabIndex = 41;
            this.rbtn_nam.TabStop = true;
            this.rbtn_nam.Text = "Nam";
            this.rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.Location = new System.Drawing.Point(260, 146);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(50, 24);
            this.rbtn_nu.TabIndex = 42;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // frmThongTinMoTaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 485);
            this.Controls.Add(this.rbtn_nu);
            this.Controls.Add(this.rbtn_nam);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_DungTich);
            this.Controls.Add(this.txt_PhienBan);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_anh);
            this.Name = "frmThongTinMoTaSanPham";
            this.Text = "frmThongTinMoTaSanPham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_DungTich;
        private System.Windows.Forms.TextBox txt_PhienBan;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_anh;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.RadioButton rbtn_nam;
        private System.Windows.Forms.RadioButton rbtn_nu;
    }
}