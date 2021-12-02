
namespace _3_GUI_PresentationLayer
{
    partial class frmDanhMucHoaDon
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_timKiem = new FontAwesome.Sharp.IconButton();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrid_Hoadon = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 567);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 55);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nháy vào ô để xem và sửa thông tin chi tiết";
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.Color.Black;
            this.btn_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timKiem.ForeColor = System.Drawing.Color.White;
            this.btn_timKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_timKiem.IconColor = System.Drawing.Color.White;
            this.btn_timKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_timKiem.IconSize = 30;
            this.btn_timKiem.Location = new System.Drawing.Point(346, 33);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(114, 41);
            this.btn_timKiem.TabIndex = 1;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(40, 40);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(273, 27);
            this.txt_timKiem.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.btn_timKiem);
            this.panel2.Controls.Add(this.txt_timKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 125);
            this.panel2.TabIndex = 2;
            // 
            // dgrid_Hoadon
            // 
            this.dgrid_Hoadon.AllowUserToAddRows = false;
            this.dgrid_Hoadon.AllowUserToDeleteRows = false;
            this.dgrid_Hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrid_Hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_Hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Hoadon.Location = new System.Drawing.Point(0, 125);
            this.dgrid_Hoadon.Name = "dgrid_Hoadon";
            this.dgrid_Hoadon.ReadOnly = true;
            this.dgrid_Hoadon.RowHeadersWidth = 51;
            this.dgrid_Hoadon.RowTemplate.Height = 29;
            this.dgrid_Hoadon.Size = new System.Drawing.Size(1215, 442);
            this.dgrid_Hoadon.TabIndex = 4;
            this.dgrid_Hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Hoadon_CellClick);
            // 
            // frmDanhMucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 622);
            this.Controls.Add(this.dgrid_Hoadon);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmDanhMucHoaDon";
            this.Text = "frmDanhMucHoaDon";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgrid_Hoadon;
    }
}