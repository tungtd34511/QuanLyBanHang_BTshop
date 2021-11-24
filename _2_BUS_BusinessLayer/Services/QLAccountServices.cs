using _1_DAL_DataAcessLayer.DALServices;
using _1_DAL_DataAcessLayer.Entities;
using _1_DAL_DataAcessLayer.IDALServices;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    class QLAccountServices : IAccountServices
    {
        private IAccountServices _iaccountServices;
        private List<Account> _lstAccounts;

        public QLAccountServices()
        {
            _iaccountServices = new QLAccountServices();
            _lstAccounts = new List<Account>();
            GetlstAccountsFromDB();
        }

        public List<Account> GetlstAccounts()
        {
            return _lstAccounts;
        }

        public void GetlstAccountsFromDB()
        {
            _lstAccounts = _iaccountServices.GetlstAccounts();
        }

        public string AddAccount(Account account)
        {
            return _iaccountServices.AddAccount(account);
            
        }

        public string DeleteAccount(int id)
        {
            return _iaccountServices.DeleteAccount(id);
        }

        public string UpdateAccount(Account account)
        {
            return  _iaccountServices.UpdateAccount(account);
        }
    }
}
