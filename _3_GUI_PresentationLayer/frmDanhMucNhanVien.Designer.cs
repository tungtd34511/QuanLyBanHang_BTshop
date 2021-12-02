
namespace _3_GUI_PresentationLayer
{
    partial class frmDanhMucNhanVien
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
            this.btn_them = new FontAwesome.Sharp.IconButton();
            this.btn_timKiem = new FontAwesome.Sharp.IconButton();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_timKiem);
            this.panel1.Controls.Add(this.txt_timKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 118);
            this.panel1.TabIndex = 0;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_them.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(126)))), ((int)(((byte)(228)))));
            this.btn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_them.IconSize = 35;
            this.btn_them.Location = new System.Drawing.Point(529, 41);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(96, 37);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_timKiem.IconColor = System.Drawing.Color.Black;
            this.btn_timKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_timKiem.IconSize = 30;
            this.btn_timKiem.Location = new System.Drawing.Point(354, 39);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(114, 41);
            this.btn_timKiem.TabIndex = 4;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(48, 46);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(273, 27);
            this.txt_timKiem.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 604);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 104);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nháy vào ô để xem và sửa thông tin chi tiết";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgrid_NhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 486);
            this.panel3.TabIndex = 2;
            // 
            // dgrid_NhanVien
            // 
            this.dgrid_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgrid_NhanVien.Name = "dgrid_NhanVien";
            this.dgrid_NhanVien.RowHeadersWidth = 51;
            this.dgrid_NhanVien.RowTemplate.Height = 29;
            this.dgrid_NhanVien.Size = new System.Drawing.Size(1222, 486);
            this.dgrid_NhanVien.TabIndex = 0;
            this.dgrid_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_NhanVien_CellClick);
            // 
            // frmDanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhMucNhanVien";
            this.Text = "frmDanhMucNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgrid_NhanVien;
        private FontAwesome.Sharp.IconButton btn_them;
        private FontAwesome.Sharp.IconButton btn_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Label label1;
    }
}