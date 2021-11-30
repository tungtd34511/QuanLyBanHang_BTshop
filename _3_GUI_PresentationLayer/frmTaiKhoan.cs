using _1_DAL_DataAcessLayer.DALServices;
using _1_DAL_DataAcessLayer.Entities;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class frmTaiKhoan : Form
    {
        private QLAccountServices _iaccountServices;
        
        private List<Account> _lstAccount;
        private Account _account;

        public frmTaiKhoan()
        {
            InitializeComponent();
            _iaccountServices = new QLAccountServices();
            _lstAccount = new List<Account>();

           
            LoaddataDgrid();

        }
        public frmTaiKhoan(Account account)
        {
            InitializeComponent();
            LoadThongTin(account);
        }

            


        

        private void LoadThongTin(Account account)
        {
            if (account != null)
            {
                txtID.Text = account.Id.ToString();
                txt_Acc.Text = account.Acc;
                txt_Pass.Text = account.Pass;
                if (account.TinhTrang == true)
                {
                    rbtn_HoatDong.Checked = true;
                }
                else
                {
                    rbtn_KhongHoatDong.Checked = true;
                }
            }
        }

        public Account GetAccount()
        {
            _account = new Account();
            _account.Id = Convert.ToInt32(txtID.Text);
            _account.Acc = txt_Acc.Text;
            _account.Pass = txt_Pass.Text;
            if (rbtn_HoatDong.Checked)
            {
                _account.TinhTrang = true;
            }
            else
            {
                _account.TinhTrang = false;
            }

            
            return _account;
        }

        public void LoaddataDgrid()
        {
            _lstAccount = _iaccountServices.GetlstAccounts();
            dgridAccount.ColumnCount = 4;
            dgridAccount.Columns[0].Name = "ID";
            dgridAccount.Columns[1].Name = "Acc";
            dgridAccount.Columns[2].Name = "Pass";
            dgridAccount.Columns[3].Name = "Tình trạng";
            dgridAccount.Rows.Clear();
            foreach (var x in _lstAccount)
            {
                dgridAccount.Rows.Add(x.Id, x.Acc, x.Pass, x.TinhTrang);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _account = new Account();
                _account.Id = Convert.ToInt32(txtID.Text);
                _account.Acc = txt_Acc.Text;
                _account.Pass = txt_Pass.Text;
                _account.TinhTrang = Convert.ToBoolean(rbtn_HoatDong.Checked == true ? "Hoạt Động" : "Không Hoạt Động");
                _iaccountServices.AddAccount(_account);
                LoadThongTin(_account);
                LoaddataDgrid();
                MessageBox.Show("THông báo", "Thên tài khoản thành công");
            }
            catch
            {

                MessageBox.Show("Thông báo", "Thêm tài thất bại");
                return;
            }
            
            
            
        }
    }
}
