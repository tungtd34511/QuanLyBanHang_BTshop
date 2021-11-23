using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAcessLayer.DatabaseContext;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;

namespace _1_DAL_DataAcessLayer.DALServices
{
    public class AccountServices : IAccountServices
    {
        private List<Account> _lstAccounts;
        private DBContext_BTShop _dbContext;
        public AccountServices()
        {
            _dbContext = new DBContext_BTShop();
            _lstAccounts = new List<Account>();
            GetlstAccountsFromDB();
        }
        public List<Account> GetlstAccounts()
        {
            return _lstAccounts;
        }

        public void GetlstAccountsFromDB()
        {
            _lstAccounts = _dbContext.TAIKHOAN.ToList();
        }

        public string AddAccount(Account account)
        {
            _dbContext.Add(account);
            _dbContext.SaveChanges();
            GetlstAccountsFromDB();
            return "Thêm thành công";
        }
        public string UpdateAccount(Account account)
        {
            var entry = _dbContext.TAIKHOAN.First(e => e.Id == account.Id);
            _dbContext.Entry(entry).CurrentValues.SetValues(account);
            _dbContext.SaveChanges();
            GetlstAccountsFromDB();
            return "Sửa thành công";
        }
        public string DeleteAccount(int id)
        {
            _dbContext.Remove(_lstAccounts.FirstOrDefault(c => c.Id == id));
            _dbContext.SaveChanges();
            GetlstAccountsFromDB();
            return "Xóa thành công";
        }
    }
}
