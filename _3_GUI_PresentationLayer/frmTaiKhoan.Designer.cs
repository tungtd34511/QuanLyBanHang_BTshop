
namespace _3_GUI_PresentationLayer
{
    partial class frmTaiKhoan
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
            this.btn_Luu = new FontAwesome.Sharp.IconButton();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.rbtn_KhongHoatDong = new System.Windows.Forms.RadioButton();
            this.rbtn_HoatDong = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Luu.IconColor = System.Drawing.Color.IndianRed;
            this.btn_Luu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Luu.IconSize = 25;
            this.btn_Luu.Location = new System.Drawing.Point(788, 152);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(94, 70);
            this.btn_Luu.TabIndex = 29;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(228, 124);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(186, 27);
            this.txt_SDT.TabIndex = 26;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(228, 174);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(186, 27);
            this.txt_email.TabIndex = 25;
            // 
            // rbtn_KhongHoatDong
            // 
            this.rbtn_KhongHoatDong.AutoSize = true;
            this.rbtn_KhongHoatDong.Location = new System.Drawing.Point(386, 279);
            this.rbtn_KhongHoatDong.Name = "rbtn_KhongHoatDong";
            this.rbtn_KhongHoatDong.Size = new System.Drawing.Size(146, 24);
            this.rbtn_KhongHoatDong.TabIndex = 24;
            this.rbtn_KhongHoatDong.TabStop = true;
            this.rbtn_KhongHoatDong.Text = "Không hoạt động";
            this.rbtn_KhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtn_HoatDong
            // 
            this.rbtn_HoatDong.AutoSize = true;
            this.rbtn_HoatDong.Location = new System.Drawing.Point(228, 281);
            this.rbtn_HoatDong.Name = "rbtn_HoatDong";
            this.rbtn_HoatDong.Size = new System.Drawing.Size(102, 24);
            this.rbtn_HoatDong.TabIndex = 23;
            this.rbtn_HoatDong.TabStop = true;
            this.rbtn_HoatDong.Text = "Hoạt động";
            this.rbtn_HoatDong.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tình trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Loại tài khoản";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(228, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 28);
            this.comboBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 29);
            this.button2.TabIndex = 32;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 29);
            this.button3.TabIndex = 33;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(55, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 214);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(851, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.rbtn_KhongHoatDong);
            this.Controls.Add(this.rbtn_HoatDong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Luu;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.RadioButton rbtn_KhongHoatDong;
        private System.Windows.Forms.RadioButton rbtn_HoatDong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}