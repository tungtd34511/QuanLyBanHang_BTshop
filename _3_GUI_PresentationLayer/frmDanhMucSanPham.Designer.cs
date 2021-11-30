
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.Models;

namespace _3_GUI_PresentationLayer
{
    partial class frmDanhMucSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgrid_DSsanPham = new System.Windows.Forms.DataGridView();
            this.lb_NgayGio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DSsanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.splitContainer1.Panel1.Controls.Add(this.txt_TimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.btn_TimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Them);
            this.splitContainer1.Panel1.Controls.Add(this.dgrid_DSsanPham);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.lb_NgayGio);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1307, 624);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(34, 49);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(386, 27);
            this.txt_TimKiem.TabIndex = 3;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(464, 49);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 29);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(34, 110);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgrid_DSsanPham
            // 
            this.dgrid_DSsanPham.AllowUserToAddRows = false;
            this.dgrid_DSsanPham.AllowUserToDeleteRows = false;
            this.dgrid_DSsanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_DSsanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_DSsanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_DSsanPham.GridColor = System.Drawing.Color.White;
            this.dgrid_DSsanPham.Location = new System.Drawing.Point(0, 150);
            this.dgrid_DSsanPham.Name = "dgrid_DSsanPham";
            this.dgrid_DSsanPham.ReadOnly = true;
            this.dgrid_DSsanPham.RowHeadersWidth = 51;
            this.dgrid_DSsanPham.RowTemplate.Height = 29;
            this.dgrid_DSsanPham.Size = new System.Drawing.Size(1307, 385);
            this.dgrid_DSsanPham.TabIndex = 0;
            this.dgrid_DSsanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_DSsanPham_CellClick);
            // 
            // lb_NgayGio
            // 
            this.lb_NgayGio.AutoSize = true;
            this.lb_NgayGio.Location = new System.Drawing.Point(878, 22);
            this.lb_NgayGio.Name = "lb_NgayGio";
            this.lb_NgayGio.Size = new System.Drawing.Size(73, 20);
            this.lb_NgayGio.TabIndex = 3;
            this.lb_NgayGio.Text = "Ngày giờ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nháy đúp để xem thông tin chi tiết của sản phẩm, và sửa thông tin";
            // 
            // frmDanhMucSanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1307, 624);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmDanhMucSanPham";
            this.Text = "Danh mục sản phẩm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DSsanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txt_TimKiem;
        private Button btn_TimKiem;
        private Button btn_Them;
        private DataGridView dgrid_DSsanPham;
        private Label lb_NgayGio;
        private Label label1;
    }
}

