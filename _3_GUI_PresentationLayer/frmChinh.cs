using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace _3_GUI_PresentationLayer
{
    public partial class frmChinh : Form
    {
        //Fields
        private IconButton currenButton;
        private Panel leftBoderbtn;

        private Form currentchildForm;
        //Struct
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 116);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Constructor
        public frmChinh()
        {
            InitializeComponent();
            leftBoderbtn = new Panel();
            leftBoderbtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBoderbtn);
            this.ActiveButton(iconButton1,RGBcolors.color3);
        }
        //Method
        private void ActiveButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                //Button
                currenButton = (IconButton) senderBtn;
                currenButton.BackColor = Color.FromArgb(37, 36, 81);
                currenButton.ForeColor = color;
                currenButton.TextAlign = ContentAlignment.MiddleCenter;
                currenButton.IconColor = color;
                currenButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenButton.ImageAlign = ContentAlignment.MiddleRight;
                //left boder 
                leftBoderbtn.BackColor = color;
                leftBoderbtn.Location = new Point(0, currenButton.Location.Y);
                leftBoderbtn.Visible = true;
                leftBoderbtn.BringToFront();
                //Title
                Title.IconChar = currenButton.IconChar;
                Title.Text = currenButton.Text;
            }
        }

        private void DisableButton()
        {
            if (currenButton != null)
            {
                currenButton.BackColor = Color.FromArgb(73, 51, 202);
                currenButton.ForeColor = Color.Gainsboro;
                currenButton.TextAlign = ContentAlignment.MiddleLeft;
                currenButton.IconColor = Color.Gainsboro;
                currenButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenchildForm(Form form)
        {
            if (currentchildForm!=null)
            {
                currentchildForm.Close();
            }
            currentchildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;
            form.BringToFront();
            form.Show();
            
        }
        //Event
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender,RGBcolors.color3);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenchildForm(new frmDanhMucSanPham());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenchildForm(new frmDanhMucHoaDon());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenchildForm(new frmBanHang());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenchildForm(new frmDanhMucNhanVien());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBcolors.color3);
            OpenchildForm(new frmDanhMucKhachHang());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
